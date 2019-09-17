using AutoMapper;
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



    }
}