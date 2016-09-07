using System.Web.Mvc;
using System.Web.Routing;
using WorkWithView.Infrastructure;

namespace WorkWithView
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Add(new CustomViewEngine());
        }
    }
}
