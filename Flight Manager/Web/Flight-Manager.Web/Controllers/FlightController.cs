namespace Flight_Manager.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Flight_Manager.Data;
    using Flight_Manager.Data.Models;
    using Flight_Manager.Web.Models;
    using Flight_Manager.Web.Models.Flight;
    using Flight_Manager.Web.Models.Shared;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [Authorize]
    public class FlightController : Controller
    {
        private readonly FlightDbContext _context;
        private const int PageSize = 10;

        public FlightController()
        {
            _context = new FlightDbContext();
        }

            
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["Id"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["LocationFrom"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["LocationTo"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["FlightTakeOff"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["FlightLanding"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["PlaneModel"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["PlaneId"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["PilotName"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CapacityNormal"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CapacityBuisness"] = sortOrder == "Date" ? "date_desc" : "Date";


            var Flight = from f in _context.Flights
                           select f;
            Flight = sortOrder switch
            {
                "Id" => Flight.OrderByDescending(f => f.Id),
                "LocationFrom" => Flight.OrderBy(f => f.LocationFrom),
                "LocationTo" => Flight.OrderBy(f => f.LocationTo),
                "FligtTakeOff" => Flight.OrderBy(f => f.FligtTakeOff),
                "FlightLanding" => Flight.OrderBy(f => f.FlightLanding),
                "PlaneModel" => Flight.OrderBy(f => f.PlaneModel),
                "PlaneId" => Flight.OrderBy(f => f.PlaneId),
                "PilotName" => Flight.OrderBy(f => f.PilotName),
                "CapacityNormal" => Flight.OrderBy(f => f.CapacityNormal),
                "CapacityBuisness" => Flight.OrderBy(f => f.CapacityBuisness),

            };

            return View(await Flight.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> Index(FlightIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<FlightViewModel> items = await _context.Flights.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(f => new FlightViewModel()
            {
                LocationFrom = f.LocationFrom,
                LocationTo = f.LocationTo,
                FligtTakeOff = f.FligtTakeOff,
                FlightLanding = f.FlightLanding,
                PlaneModel = f.PlaneModel,
                PlaneId = f.PlaneId,
                PilotName = f.PilotName,
                CapacityNormal = f.CapacityNormal,
                CapacityBuisness = f.CapacityBuisness

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Flights.CountAsync() / (double)PageSize);

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FlightCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Flight flight = new Flight
                {
                    LocationFrom = model.LocationFrom,
                    LocationTo = model.LocationTo,
                    FligtTakeOff = model.FligtTakeOff,
                    FlightLanding = model.FlightLanding,
                    PlaneModel = model.PlaneModel,
                    PlaneId = model.PlaneId,
                    PilotName = model.PilotName,
                    CapacityNormal = model.CapacityNormal,
                    CapacityBuisness = model.CapacityBuisness
                };

                _context.Add(flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight flight = await _context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }

            FlightEditViewModel model = new FlightEditViewModel
            {
                Id = flight.Id,
                LocationFrom = flight.LocationFrom,
                LocationTo = flight.LocationTo,
                FligtTakeOff = flight.FligtTakeOff,
                FlightLanding = flight.FlightLanding,
                PlaneModel = flight.PlaneModel,
                PlaneId = flight.PlaneId,
                PilotName = flight.PilotName,
                CapacityNormal = flight.CapacityNormal,
                CapacityBuisness = flight.CapacityBuisness
            };

            return View(model);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FlightEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Flight book = new Flight
                {
                    Id = model.Id,
                    LocationFrom = model.LocationFrom,
                    LocationTo = model.LocationTo,
                    FligtTakeOff = model.FligtTakeOff,
                    FlightLanding = model.FlightLanding,
                    PlaneModel = model.PlaneModel,
                    PlaneId = model.PlaneId,
                    PilotName = model.PilotName,
                    CapacityNormal = model.CapacityNormal,
                    CapacityBuisness = model.CapacityBuisness
                };

                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Flight flight = await _context.Flights.FindAsync(id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.Id == id);
        }
    }
}