using System.Collections.Generic;
using System.Linq;
using RestaurantInfo.Models;

namespace RestaurantInfo.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private static List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Fat Hoe Burgers", Cuisine = CuisineType.American },
                new Restaurant { Id = 2, Name = "Joe's Pizza House", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 3, Name = "Sum Ting Wong Palace", Cuisine = CuisineType.Chinese }
            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);

            return restaurant;
        }

        public Restaurant Update(Restaurant newRestaurant)
        {
            var oldRestaurant = Get(newRestaurant.Id);
            if (oldRestaurant != null)
            {
                _restaurants.Remove(oldRestaurant);
                newRestaurant.Id = oldRestaurant.Id;
                _restaurants.Add(newRestaurant);
            }

            return newRestaurant;
        }
    }
}
