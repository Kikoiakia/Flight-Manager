namespace Flight_Manager.Web.Controllers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using Flight_Manager.Data;
    using Flight_Manager.Data.Models;
    using Flight_Manager.Web.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class FlightController : Controller
    {
        private readonly FlightDbContext _context;
        private const int PageSize = 10;

        public FlightController(FlightDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(FlightCreateViewModel model)
        {
            if (ModelState.IsValid)
            {

                Flight flight = new Flight
                {
                    Id = Guid.NewGuid().ToString(),
                    LocationFrom = model.LocationFrom,
                    LocationTo = model.LocationTo,
                    FlightTakeOff = model.FlightTakeOff,
                    FlightLanding = model.FlightLanding,
                    PlaneModel = model.PlaneModel,
                    PlaneId = model.PlaneId,
                    PilotName = model.PilotName,
                    CapacityNormal = model.CapacityNormal,
                    CapacityBuisness = model.CapacityBuisness
                };


                var checkFlight = _context.Flights.FirstOrDefault(f => f.PlaneId == flight.PlaneId);
                if (checkFlight != null)
                {
                    ViewBag.Message = $"Plane id {flight.PlaneId} already exists";

                    return View(model);
                }

                _context.Add(flight);
                await _context.SaveChangesAsync();
                return Redirect("/Identity/FlightList");



            }

            return View(model);
        }


    }
}