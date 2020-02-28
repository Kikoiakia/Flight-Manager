using Microsoft.AspNetCore.Identity;

namespace Flight_Manager.Data.Models
{
    public class FlightUser : IdentityUser<string>
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public int PersonalId { get; set; }

        public string Address { get; set; }


    }
}
