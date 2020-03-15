namespace Flight_Manager.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Flight_Manager.Data;
    using Flight_Manager.Data.Models;
    using Flight_Manager.Web.Models.Reservations;
    using Microsoft.AspNetCore.Mvc;
    public class ReservationController : Controller
    {
        private readonly FlightDbContext _context;

        public ReservationController(FlightDbContext context)
        {
            _context = context;
        }

        public IActionResult Reservate(string id)
        {
            var model = new ReservationCreateViewModel()
            {
                PlaneId = id
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(string id)
        {
            var model = new ReservationCreateViewModel()
            {
                PlaneId = id
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservationCreateViewModel model)
        {
            if (ModelState.IsValid)
            {

                Reservation _reservation = new Reservation
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.Name,
                    MiddleName = model.MiddleName,
                    Surname = model.Surname,
                    PersonalId = model.PersonalId,
                    Telephone = model.Telephone,
                    Nationality = model.Nationality,
                    FlightTypeId = _context.FlightTypes.FirstOrDefault(f => f.Type == model.TypeName).Id,
                    PlaneId = model.PlaneId
                };

                var CapacityBuisness = _context.Flights.FirstOrDefault(f => f.Id == model.PlaneId).CapacityBuisness;
                var CapacityNormal = _context.Flights.FirstOrDefault(f => f.Id == model.PlaneId).CapacityNormal;


                if (model.TypeName == "Buisness Class")
                {
                    if (--CapacityBuisness < 0)
                    {
                        ViewBag.Message = $"No more seats left in the Buisness Class";

                        return View(model);
                    }

                    _context.Flights.FirstOrDefault(f => f.Id == model.PlaneId).CapacityBuisness--;
                    await _context.SaveChangesAsync();
                }

                else
                {
                    if (--CapacityNormal < 0)
                    {
                        ViewBag.Message = $"No more seats left in the Economy Class";

                        return View(model);
                    }

                    _context.Flights.FirstOrDefault(f => f.Id == model.PlaneId).CapacityNormal--;
                    await _context.SaveChangesAsync();
                }

                _context.Add(_reservation);
                await _context.SaveChangesAsync();


                return Redirect("/");
            }

            return View(model);
        }
    }
}