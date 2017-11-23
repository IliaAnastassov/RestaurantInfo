using Microsoft.Extensions.Configuration;

namespace RestaurantInfo
{
    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetGreeting()
        {
            return _configuration["Greeting"];
        }
    }
}
