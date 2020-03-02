namespace Flight_Manager.Web.Areas.Identity.Pages.FlightList
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Flight_Manager.Data;
    using Flight_Manager.Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;

    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly FlightDbContext context;
        public IndexModel(FlightDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Flight> Flights { get; set; }
        public async Task OnGet()
        {
            Flights = await context.Flights.ToListAsync();

        }
        public async Task<IActionResult> OnPostDelete(string id)
        {
            var flight = await context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }
            context.Flights.Remove(flight);
            await context.SaveChangesAsync();
            return Redirect("FlightList/Index");

        }
    }
}
