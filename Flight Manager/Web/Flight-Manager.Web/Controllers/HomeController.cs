using Flight_Manager.Data;
using Flight_Manager.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Flight_Manager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly FlightDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;

        public HomeController(FlightDbContext _context, RoleManager<IdentityRole> roleManager)
        {
            this._context = _context;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            IdentityRole nonAdminRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "NotAdmin" };
            IdentityRole adminRole = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Admin" };

            await this.roleManager.CreateAsync(nonAdminRole);
            await this.roleManager.CreateAsync(adminRole);

            return View();
        }

        public IActionResult FlightCreate()
        {
            FlightCreateViewModel model = new FlightCreateViewModel();

            return View(model);
        }
        public IActionResult Flights()
        {
            FlightViewModel model = new FlightViewModel();

            return View(model);
        }

    }
}
