using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaAzienda.Controllers
{
    [Area(areaName: "AreaAzienda")]
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}