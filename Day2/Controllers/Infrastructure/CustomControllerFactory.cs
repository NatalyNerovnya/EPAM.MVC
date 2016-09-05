using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Controllers.Controllers;

namespace Controllers.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            disposable?.Dispose();
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targetType = null;
            switch(controllerName)
            {
                case "Product":
                    targetType = typeof(ProductController);
                    break;
                case "Customer":
                    targetType = typeof(CustomerController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Product";
                    targetType = typeof(ProductController);
                    break;
            }

            return targetType == null ? null : (IController)DependencyResolver.Current.GetService(targetType);
        }
    }
}