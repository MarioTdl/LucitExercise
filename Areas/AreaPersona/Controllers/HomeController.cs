using AutoMapper;
using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Core.Model;
using esercizioUnikey.Repository.Interfaccia;
using Microsoft.AspNetCore.Mvc;

namespace esercizioUnikey.Areas.AreaPersona.Controllers
{
    [Area(areaName: "AreaPersona")]
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        public HomeController(IHomeRepository homeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _homeRepository = homeRepository;
        }
        public IActionResult Index([FromRoute] int id)
        {
            var personaDb = _homeRepository.GetPersona(id);

            return View(_mapper.Map<Persona, PersonaResource>(personaDb));
        }

        [HttpPost]
        public void EditPersona([FromForm] PersonaResource personaResource)
        {
            _homeRepository

        }

    }
}