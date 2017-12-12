using System.Collections.Generic;
using RestaurantInfo.Models;

namespace RestaurantInfo.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
