namespace Flight_Manager.Web.Areas.Identity.Pages.FlightList
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using AspNetCore.CustomValidation.Attributes;
    using Flight_Manager.Data;
    using Flight_Manager.Web.Models.Flight;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    [Authorize]
    public class EditModel : PageModel
    {
        private readonly FlightDbContext context;

        public EditModel(FlightDbContext context)
        {
            this.context = context;
        }


        [BindProperty]
        public FlightModel Flight { get; set; }

        public class FlightModel
        {
            [HiddenInput]
            public string Id { get; set; }

            [Required]
            public string LocationFrom { get; set; }

            [Required]
            public string LocationTo { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            public DateTime FlightTakeOff { get; set; }

            [Required]
            [CompareTo(nameof(FlightTakeOff), ComparisonType.GreaterThanOrEqual, ErrorMessage = "Landing Date/Time must be after Flight Take Off")]
            public DateTime FlightLanding { get; set; }

            [Required]
            
            public string PlaneModel { get; set; }


            public string PlaneId { get; set; }

            [Required]
            public string PilotName { get; set; }

            [Required]
            [Range(1, 300)]
            public int CapacityNormal { get; set; }

            [Required]
            [Range(1, 300)]
            public int CapacityBuisness { get; set; }

        }

        public async Task OnGet(string id)
        {
            var FlightFromDb = await context.Flights.FindAsync(id);
            Flight = new FlightModel()
            {
                Id = FlightFromDb.Id,
                CapacityBuisness = FlightFromDb.CapacityBuisness,
                CapacityNormal = FlightFromDb.CapacityNormal,
                FlightLanding = FlightFromDb.FlightLanding,
                FlightTakeOff = FlightFromDb.FlightTakeOff,
                LocationFrom = FlightFromDb.LocationFrom,
                LocationTo = FlightFromDb.LocationTo,
                PilotName = FlightFromDb.PilotName,
                PlaneId = FlightFromDb.PlaneId,
                PlaneModel = FlightFromDb.PlaneModel
            };


        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                var FlightFromDb = await context.Flights.FindAsync(Flight.Id);
                FlightFromDb.CapacityBuisness = Flight.CapacityBuisness;
                FlightFromDb.CapacityNormal = Flight.CapacityNormal;
                FlightFromDb.FlightLanding = Flight.FlightLanding;
                FlightFromDb.FlightTakeOff = Flight.FlightTakeOff;
                FlightFromDb.LocationFrom = Flight.LocationFrom;
                FlightFromDb.LocationTo = Flight.LocationTo;
                FlightFromDb.PilotName = Flight.PilotName;
                FlightFromDb.PlaneId = Flight.PlaneId;
                FlightFromDb.PlaneModel = Flight.PlaneModel;

                await context.SaveChangesAsync();

                return Redirect("/Identity/FlightList");
            }
            return RedirectToPage();
        }


    }
}
