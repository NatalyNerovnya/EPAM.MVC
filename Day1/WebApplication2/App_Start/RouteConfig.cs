using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

            routes.MapRoute(
                name: "Default",
                url: "{controller}/Index/{str}",
                defaults: new { controller = "Home", action = "Index", str = UrlParameter.Optional},
                namespaces: new[] { "WebApplication2.Controllers.AnotherController" } //,
                //constraints: new { controller = "^H.*", id = @"\d{2}", , httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
               name: "Default2",
               url: "{controller}/{action}",
               defaults: new { controller = "Home", action = "Index"},
               namespaces: new[] { "WebApplication2.Controllers" }
               );

        }
    }
}
