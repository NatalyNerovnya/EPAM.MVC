using System.Web.Mvc;
using System.Web.Routing;
using Machine.Specifications;
using WebApplication2;

namespace WebAplication2Tests
{
    [Subject(typeof(RouteConfig), "Routing")]
    public class When_routing_without_controller_and_action
    {
        private static RouteCollection routes;
        private static RouteData result;
        private static string url;
        private static string controller;
        private static string action;
        private static string str;

        Establish context = () => 
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);    //attempts to map a route to the specified virtual URL and compares the route data to a dictionary of name/value pairs
            url = "~";
            controller = "Home";
            action = "Index";
            str = "Another controller";
        };

        Because of = () => result.Route = new Route(url, new MvcRouteHandler());

        It should_go_to_default_controller_page = () => url.Route().ShouldMapTo<WebApplication2.Controllers.AnotherController.HomeController>();

        //     It should_direct_user_to_another_controller_page = () =>
        //Browser.Uri.Route().ShouldMapTo<WebApplication2.Controllers.AnotherController.HomeController>(x => x.About());

    }
}
