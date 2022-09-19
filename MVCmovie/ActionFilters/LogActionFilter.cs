

using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web; 

//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.IO; 



namespace MVCmovie.ActionFilters
{
    
    public class LogActionFilter : ActionFilterAttribute //,IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("Logging action at OnActionExecuted" + filterContext.Result.ToString());

           // Log("OnActionExecuted", filterContext.RouteData);
            //base.OnActionExecuted(filterContext.HttpContext.Req);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("OnActionExecuting", filterContext.Result.ToString());
            
        }


    public override void OnResultExecuted(ResultExecutedContext filterContext)
    {
        Console.WriteLine("OnResultExecuted", filterContext.Result.ToString());
    }
    public override void OnResultExecuting(ResultExecutingContext filterContext)
    {
        Console.WriteLine("OnResultExecuting", filterContext.Result.ToString());
    }


    /*private void Log(string methodName, RouteData routeData)
    {
        var controllerName = routeData.Values["controller"];
        var actionName = routeData.Values["action"];
        var message = String.Format("{0} controller:{1} action:{2}", methodName, controllerName, actionName);
        Debug.WriteLine(message, "Action Filter Log");
    }*/
    }
}

    

