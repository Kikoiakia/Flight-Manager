
namespace Flight_Manager.Web.Models.Flight
{
    using Shared;
    using System.Collections.Generic;
    public class FlightIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<FlightViewModel> Items { get; set; }
    }
}
