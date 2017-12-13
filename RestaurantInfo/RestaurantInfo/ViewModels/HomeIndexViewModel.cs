using System.Collections.Generic;
using RestaurantInfo.Models;

namespace RestaurantInfo.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public string CurrentMessage { get; set; }
    }
}
