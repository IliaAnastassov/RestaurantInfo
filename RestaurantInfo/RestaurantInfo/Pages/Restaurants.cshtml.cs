using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantInfo.Models;
using RestaurantInfo.Services;

namespace RestaurantInfo.Pages
{
    public class RestaurantsModel : PageModel
    {
        private IRestaurantData _restaurantData;

        public IEnumerable<Restaurant> Restaurants { get; set; }

        public RestaurantsModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Restaurants = _restaurantData.GetAll();
        }
    }
}