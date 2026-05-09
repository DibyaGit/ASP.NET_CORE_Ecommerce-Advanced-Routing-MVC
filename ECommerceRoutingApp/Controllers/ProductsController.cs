using Microsoft.AspNetCore.Mvc;

namespace ECommerceRoutingApp.Controllers
{
    public class ProductsController : Controller
    {
        // Our original complex route
        [Route("Products/{category}/{id}")]
        public IActionResult Details(string category, int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;
            return View();
        }

        // ---> NEW CODE: Our Filter route with the custom security guard <---
        // Notice the ":validcategory" part!
        [Route("Products/Filter/{category:validcategory}/{priceRange}")]
        public IActionResult Filter(string category, string priceRange)
        {
            // If the guard lets them through, we show them the filtered results
            ViewBag.FilteredCategory = category;
            ViewBag.PriceRange = priceRange;
            return View();
        }
    }
}