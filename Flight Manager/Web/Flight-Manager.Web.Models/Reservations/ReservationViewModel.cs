﻿namespace Flight_Manager.Web.Models.Reservations
{
    using System.Collections.Generic;

    public class ReservationViewModel
    {
        public List<ReservationModel> Reservations { get; set; }
    }

    public class ReservationModel
    {
        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string PersonalId { get; set; }

        public string Telephone { get; set; }

        public string Nationality { get; set; }

        public string FlightType { get; set; }

        public string PlaneId { get; set; }

    }
}
