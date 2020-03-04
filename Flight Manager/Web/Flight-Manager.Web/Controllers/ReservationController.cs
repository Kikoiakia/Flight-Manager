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
        public IActionResult Reservate()
        {
            var model = new ReservationCreateViewModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var reservation in model.Reservations)
                {
                    Reservation _reservation = new Reservation
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = reservation.Name,
                        MiddleName = reservation.MiddleName,
                        Surname = reservation.Surname,
                        PersonalId = reservation.PersonalId,
                        Telephone = reservation.Telephone,
                        Nationality = reservation.Nationality,
                        FlightTypeId = _context.FlightTypes.FirstOrDefault(f => f.Type == reservation.FlightType).Id,
                        PlaneId = reservation.PlaneId
                    };
                    _context.Add(_reservation);
                    await _context.SaveChangesAsync();
                }
               
                return Redirect("/");
            }

            return View(model);
        }
    }
}