namespace Flight_Manager.Web.Models
{
    using AspNetCore.CustomValidation.Attributes;
    using System;
    using System.ComponentModel.DataAnnotations;
    public class FlightCreateViewModel
    {
        [Required]
        public string LocationFrom { get; set; }

        [Required]
        public string LocationTo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FligtTakeOff { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
    //  [CompareTo(nameof(FligtTakeOff), ComparisonType.SmallerThan, ErrorMessage = "Landing Date/Type must be after Flight Take Off")]
        public DateTime FlightLanding { get; set; }

        [Required]
        public string PlaneModel { get; set; }

        [Required]
        public int PlaneId { get; set; }

        [Required]
        public string PilotName { get; set; }

        [Required]
        [Range(1, 900)]
        public int CapacityNormal { get; set; }

        [Required]
        [Range(1, 100)]
        public int CapacityBuisness { get; set; }


    }
}

