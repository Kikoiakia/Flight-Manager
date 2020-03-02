namespace Flight_Manager.Web.Areas.Identity.Pages.FlightList
{
    using Flight_Manager.Data;
    using Flight_Manager.Data.Models;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    [Authorize]
    public class InfoModel : PageModel
    {
        private readonly FlightDbContext context;

        public InfoModel(FlightDbContext context)
        {
            this.context = context;
        }
        public Flight Flight { get; set; }
        public List<Reservation> Reservations { get; set; }

        public async Task OnGet(string id)
        {
            Reservations = new List<Reservation>();
            Flight = await context.Flights.FindAsync(id);
            var allReservations = await context.Reservations.ToListAsync();
            foreach (var element in allReservations)
            {
                if (element.PlaneId == Flight.PlaneId)
                {
                    Reservations.Add(element);
                }
            }
        }
    }
}
