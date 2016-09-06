using ControllerTask_CustomFactory.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerTask_CustomFactory
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
        }
    }
}
