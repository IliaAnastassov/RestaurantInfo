using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantInfo.Models;
using RestaurantInfo.Services;

namespace RestaurantInfo.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private IRestaurantData _restaurantData;

        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Restaurants = _restaurantData.GetAll();
        }
    }
}