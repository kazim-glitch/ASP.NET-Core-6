using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;



namespace MVCmovie.Controllers
{

    /*public class AdminController : Controller
    {
        //
    }*/
    //[SampleActionFilter]
    public class DataController : Controller
    {
        //[OutputCache(Duration=10)]

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(
            $"- {nameof(DataController)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(
           $"- {nameof(DataController)}.{nameof(OnActionExecuted)}");
            base.OnActionExecuted(context);
        }
        public IActionResult Index()
        {
            Console.WriteLine(
            $"- {nameof(DataController)}.{nameof(Index)}");

            return Content("Check the Console.");

            //return View();
        }



    }
}
