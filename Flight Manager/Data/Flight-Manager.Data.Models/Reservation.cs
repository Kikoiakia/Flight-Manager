namespace Flight_Manager.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public int PersonalId { get; set; }

        public string Telephone { get; set; }

        public string Nationality { get; set; }

        public FlightType FlightType { get; set; }
    }
}
