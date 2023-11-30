using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name,int numTimes)
        {
            ViewData["Message"] = "hello user " + name;
            ViewData["NumTimes"] = numTimes;
            return View();

        }

    }
}
