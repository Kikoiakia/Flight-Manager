using Flight_Manager.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationManager.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly FlightDbContext context;
        public UsersController(FlightDbContext context)
        {
            this.context = context;
        }
        
    }

}
