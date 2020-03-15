using Flight_Manager.Data;
using Flight_Manager.Web.Models;
using Flight_Manager.Web.Models.Flight;
using Flight_Manager.Web.Models.Reservations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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

            var model = new FlightIndexViewModel
            {
                Items = _context.Flights.Select(f => new FlightViewModel
                {
                    Id = f.Id,
                    LocationFrom = f.LocationFrom,
                    LocationTo = f.LocationTo,
                    FlightTakeOff = f.FlightTakeOff,
                    FlightLanding = f.FlightLanding,
                    PlaneModel = f.PlaneModel,
                    PlaneId = f.PlaneId,
                    PilotName = f.PilotName,
                    CapacityNormal = f.CapacityNormal,
                    CapacityBuisness = f.CapacityBuisness

                }).ToList()
            };
            return View(model);  
        }

        public ActionResult Reservate(string id)
        {
            return RedirectToAction("Reservate", "Reservation",id);
        }
    }
}
