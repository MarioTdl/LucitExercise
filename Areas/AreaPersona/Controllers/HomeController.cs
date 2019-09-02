using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaPersona.Controllers
{   
    [Area(areaName: "AreaPersona")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}