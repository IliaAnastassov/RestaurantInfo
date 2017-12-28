using Microsoft.EntityFrameworkCore;
using RestaurantInfo.Models;

namespace RestaurantInfo.Data
{
    public class RestaurantInfoDbContext : DbContext
    {
        public RestaurantInfoDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
