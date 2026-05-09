using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace ECommerceRoutingApp.Constraints
{
    // This tells the app: "I am a Route Security Guard"
    public class ValidCategoryConstraint : IRouteConstraint
    {
        // Here is the list of departments our store actually has
        private string[] _validCategories = new[] { "electronics", "clothing", "books" };

        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            // 1. Grab the word the user typed in the URL
            if (values.TryGetValue(routeKey, out object? value) && value != null)
            {
                // Make it lowercase just to be safe
                var category = value.ToString()?.ToLower();

                // 2. Check if that word is in our official list
                if (_validCategories.Contains(category))
                {
                    return true; // Let them in!
                }
            }

            // 3. If it is NOT in our list, block them!
            return false;
        }
    }
}