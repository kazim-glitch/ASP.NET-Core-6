using Microsoft.AspNetCore.Mvc;
using MVCmovie.Models;
using System.Collections.Generic; 
using System.Diagnostics;
using MVCmovie.ActionFilters; 


namespace MVCmovie.Controllers
{


    /*[ServiceFilter(typeof(LogActionFilter))]
    [Route("api/[controller]")]*/
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       
     
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        //        [HandleError]
        [LogActionFilter]
        public IActionResult Index()
        {
            Console.WriteLine("Inside Index");
            return View();

        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}