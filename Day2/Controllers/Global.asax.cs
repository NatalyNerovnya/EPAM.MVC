using System.Web.Mvc;
using System.Web.Routing;
using Controllers.Infrastructure;

namespace Controllers
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory(new CustomControllerActivator()));
        }
    }
}
