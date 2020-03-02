namespace Flight_Manager.Web.Models.Reservations
{
    using Flight_Manager.Data.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ReservationCreateViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]    
        public string PersonalId { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public FlightType FlightType { get; set; }

        [Required]
        [Range(1, 900)]
        public string PlaneId { get; set; }



    }
}
