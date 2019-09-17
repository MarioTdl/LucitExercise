using System.Collections.Generic;
using System.Threading;
using AutoMapper;
using esercizioUnikey.Areas.AreaAzienda.Controllers.Resource;
using esercizioUnikey.Areas.AreaAzienda.Resource;
using esercizioUnikey.Core.Model;
using esercizioUnikey.Interfaccia;
using esercizioUnikey.Repository.Interfaccia;
using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaAzienda.Controllers
{
    [Area(areaName: "AreaAzienda")]
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IHomeRepository homeRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index([FromRoute] int id)
        {
            var aziendaDb = _homeRepository.GetCompany(id);

            return View(_mapper.Map<Company, CompanyResource>(aziendaDb));
        }

        public IActionResult EditAzienda([FromForm] CompanyResource companyResource)
        {
            var company = _homeRepository.GetCompany(companyResource.Id);

            _mapper.Map<CompanyResource, Company>(companyResource, company);

            _unitOfWork.CompleteAsync();

            return RedirectToAction("Index", "Home", new { area = "AreaAzienda", id = companyResource.Id });
        }
        public IActionResult CreateEmployeer([FromRoute] int id)
        {
            return View(new DipendenteResource { Id = id });
        }
        [HttpPost]
        public IActionResult CreateEmployeer(DipendenteResource dipendenteResource)
        {
            var dipendente = _mapper.Map<DipendenteResource, Dipendente>(dipendenteResource);
            _homeRepository.AddDipendente(dipendente);

            _unitOfWork.CompleteAsync();

            return RedirectToAction("Index", "Home", new { area = "AreaAzienda", id = dipendenteResource.CompanyId });
        }
        public IActionResult ViewDipendenti([FromRoute] int id)
        {
            List<DipendenteResource> listaDipendenti = new List<DipendenteResource>();
            var dipendenti = _homeRepository.GetDipendenti(id);
            foreach (var dipendete in dipendenti)
            {
                listaDipendenti.Add(_mapper.Map<Dipendente, DipendenteResource>(dipendete));
            }
            return View(listaDipendenti);
        }
        [HttpPost]
        public IActionResult Delete( DipendenteResource dipendente)
        {
            int idAzienda = dipendente.CompanyId;
            _homeRepository.DeleteDipendente(dipendente.Id);
            _unitOfWork.CompleteAsync();
            return RedirectToAction("ViewDipendenti", "Home", new { area = "AreaAzienda", id = idAzienda });
        }

    }
}