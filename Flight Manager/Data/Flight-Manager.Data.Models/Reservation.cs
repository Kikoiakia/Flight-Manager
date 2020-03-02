namespace Flight_Manager.Data.Models
{
    public class Reservation
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string PersonalId { get; set; }

        public string Telephone { get; set; }

        public string Nationality { get; set; }

        public FlightType FlightType { get; set; }

        public string PlaneId { get; set; }
    }
}
