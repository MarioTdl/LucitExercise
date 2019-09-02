using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaPersona.Controllers
{   
    [Area("AreaPersona")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}