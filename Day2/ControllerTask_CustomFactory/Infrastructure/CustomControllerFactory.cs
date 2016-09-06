using ControllerTask_CustomFactory.Controllers;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace ControllerTask_CustomFactory.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            switch(controllerName)
            {
                case "Home":
                    return SessionStateBehavior.Disabled;
                default:
                    return SessionStateBehavior.Default;
            }                
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            disposable?.Dispose();
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targetType = null;
            switch (controllerName)
            {
                case "Customer":
                    targetType = typeof(CustomerController);
                    break;
                case "User":
                    targetType = typeof(CustomerController);
                    break;
                case "Home":
                    targetType = typeof(HomeController);
                    break;
                case "Base":
                    targetType = typeof(BaseController);
                    break;
                case "Admin":
                    targetType = typeof(AdminController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Home";
                    targetType = typeof(HomeController);
                    break;
            }

            return targetType == null ? null : (IController)DependencyResolver.Current.GetService(targetType);
        }
    }
}