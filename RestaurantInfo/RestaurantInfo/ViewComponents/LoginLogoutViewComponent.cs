using Microsoft.AspNetCore.Mvc;

namespace RestaurantInfo.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
