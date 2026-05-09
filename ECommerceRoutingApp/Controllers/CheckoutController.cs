using Microsoft.AspNetCore.Mvc;

namespace ECommerceRoutingApp.Controllers
{
    public class CheckoutController : Controller
    {
        // This is our Checkout Bouncer. It checks the user's status.
        public IActionResult Index(string status)
        {
            if (status == "loggedin")
            {
                // If they are logged in, send them to the Payment screen
                return RedirectToAction("Payment");
            }
            else
            {
                // If they are anything else (like a guest), send them to the Login screen
                return RedirectToAction("Login");
            }
        }

        // The secure payment room
        public IActionResult Payment()
        {
            return View();
        }

        // The login room
        public IActionResult Login()
        {
            return View();
        }
    }
}