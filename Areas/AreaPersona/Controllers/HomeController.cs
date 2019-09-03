using AutoMapper;
using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Core.Model;
using esercizioUnikey.Interfaccia;
using esercizioUnikey.Repository.Interfaccia;
using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaPersona.Controllers
{
    [Area(areaName: "AreaPersona")]
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IHomeRepository homeRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _homeRepository = homeRepository;
        }
        public IActionResult Index([FromRoute] int id)
        {
            var personaDb = _homeRepository.GetPersona(id);

            return View(_mapper.Map<Persona, PersonaResource>(personaDb));
        }

        [HttpPost]
        public IActionResult EditPersona([FromForm] PersonaResource personaResource)
        {
            var persona = _homeRepository.GetPersona(personaResource.Id);

            _mapper.Map<PersonaResource, Persona>(personaResource, persona);

            _unitOfWork.CompleteAsync();

            return RedirectToAction("Index", "Home", new { area = "AreaPersona", id = personaResource.Id });

        }
        public IActionResult CreateOrder([FromRoute] int Id)
        {
            return View();
        }
    }
}