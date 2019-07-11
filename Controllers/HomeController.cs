using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   
    {
        
        [HttpGet]       
        [Route("")]
        public ViewResult Index()
        {
        return View();
        }     
        [HttpPost("process")]
        public IActionResult Process(string name, string location, string lang, string comment )
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.lang = lang;
            ViewBag.comment = comment;
            return View();
        }

    }
}
