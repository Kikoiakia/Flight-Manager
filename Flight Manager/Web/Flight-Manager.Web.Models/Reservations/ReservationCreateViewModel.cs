namespace Flight_Manager.Web.Models.Reservations
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ReservationCreateViewModel
    {

        [HiddenInput]
        public string PlaneId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]    
        public string PersonalId { get; set; }

        [Required]
        [Phone]
        public string Telephone { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]

        public string TypeName { get; set; }




    }
}
