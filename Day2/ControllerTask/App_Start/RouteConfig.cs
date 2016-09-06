using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerTask
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CustomerController",
                url: "Customer/{action}",
                defaults: new { controller = "Customer", action = "Show" }
            );

            routes.MapRoute(
                name: "UserController",
                url: "User/{action}",
                defaults: new { controller = "Customer", action = "Show" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );

            
        }
    }
}
