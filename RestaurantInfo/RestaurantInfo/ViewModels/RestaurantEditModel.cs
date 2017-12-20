using System.ComponentModel.DataAnnotations;
using RestaurantInfo.Models;

namespace RestaurantInfo.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
