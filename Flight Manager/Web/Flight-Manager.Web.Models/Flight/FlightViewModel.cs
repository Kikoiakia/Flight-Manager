namespace Flight_Manager.Web.Models
{
    using System;

    public class FlightViewModel
    {
        public int Id { get; set; }
        public string LocationFrom { get; set; }

        public string LocationTo { get; set; }

        public DateTime FligtTakeOff { get; set; }

        public DateTime FlightLanding { get; set; }

        public string PlaneModel { get; set; }

        public int PlaneId { get; set; }

        public string PilotName { get; set; }

        public int CapacityNormal { get; set; }

        public int CapacityBuisness { get; set; }
    }
}
