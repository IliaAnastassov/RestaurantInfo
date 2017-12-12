using System.Collections.Generic;
using System.Linq;
using RestaurantInfo.Models;

namespace RestaurantInfo.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Fat Hoe Burgers" },
                new Restaurant { Id = 2, Name = "Joe's Pizza House" },
                new Restaurant { Id = 3, Name = "Sum Ting Wong Palace" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
