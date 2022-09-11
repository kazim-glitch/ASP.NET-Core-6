using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web; 


namespace MVCmovie.Controllers
{
    public class helloworldcontroller : Controller
    {
        /*public string Index()
        {

            return "this is my default action..";
        }*/
        
       public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes; 
           // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is :{numTimes}");
            return View();
                //"This is welcome action method";
        }

    }
}
