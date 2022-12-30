using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class GameController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SatinAl()
        { 
            return View(); 
        }
    }
}
