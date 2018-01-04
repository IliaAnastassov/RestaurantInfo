using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantInfo.Services;

namespace RestaurantInfo.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;

        public string Greeting { get; set; }

        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public void OnGet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Greeting = _greeter.GetGreeting();
            }
            else
            {
                Greeting = $"{name}, {_greeter.GetGreeting()}";
            }
        }
    }
}