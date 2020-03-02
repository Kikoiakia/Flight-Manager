namespace Flight_Manager.Web.Areas.Identity.Pages.UserList
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Flight_Manager.Data;
    using Flight_Manager.Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;

    public class IndexModel : PageModel
    {

        private readonly FlightDbContext context;
        public IndexModel(FlightDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<FlightUser> Users { get; set; }
        public async Task OnGet()
        {
            Users = await context.Users.ToListAsync();

        }
        public async Task<IActionResult> OnPostDelete(string id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return Redirect("UserList/Index");

        }
    }
}
