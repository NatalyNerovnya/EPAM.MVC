using System;
using System.Web.Mvc;

namespace WorkWithView.Infrastructure
{
    public class CustomViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new NotImplementedException();
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if(viewName == "CustomData")
            {
                return new ViewEngineResult(new CustomDataView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] { "No view (Custom View Engine)" });
            }
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            throw new NotImplementedException();
        }
    }
}