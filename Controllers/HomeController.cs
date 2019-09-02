using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using esercizioUnikey.Models;
using esercizioUnikey.Controllers.Resource;
using esercizioUnikey.Repository.Interfaccia;

namespace esercizioUnikey.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login(FormInput formInput)
        {
            string areaRitorno = _homeRepository.RedirectToArea(formInput.Username, formInput.Password);

            if (areaRitorno == "isPerson")
                CreatedAtRoute("areaRoute", new { area = "AreaPersona" });
            else if (areaRitorno == "isCompany")
                RedirectToAction("areaRoute", new { area = "AreaAzienda" });

            return RedirectToRoute("Index", "Home");
        }
    }
}
