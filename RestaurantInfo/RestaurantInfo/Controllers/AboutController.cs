using Microsoft.AspNetCore.Mvc;

namespace RestaurantInfo.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1-666-999";
        }

        public string Address()
        {
            return "Route 66";
        }
    }
}
