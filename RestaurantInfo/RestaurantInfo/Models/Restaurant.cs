using System.ComponentModel.DataAnnotations;

namespace RestaurantInfo.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "Restaurant Name:")]
        public string Name { get; set; }

        [Display(Name = "Cuisine Type:")]
        public CuisineType Cuisine { get; set; }
    }
}
