using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaAzienda.Controllers
{
    [Area("AreaAzienda")]
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}