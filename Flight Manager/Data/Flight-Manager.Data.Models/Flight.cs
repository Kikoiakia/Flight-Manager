﻿using System;

namespace Flight_Manager.Data.Models
{
    public class Flight
    {
        public string Id { get; set; }
        public string LocationFrom { get; set; }

        public string LocationTo { get; set; }

        public DateTime FlightTakeOff { get; set; }

        public DateTime FlightLanding { get; set; }

        public string PlaneModel { get; set; }

        public string PlaneId { get; set; }

        public string PilotName { get; set; }

        public int CapacityNormal{ get; set; }

        public int CapacityBuisness { get; set; }
    }
}
