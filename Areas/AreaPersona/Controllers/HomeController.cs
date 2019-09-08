using System.Collections.Generic;
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
            int i = 0;
            IEnumerable<Prodotto> prodotti = _homeRepository.GetProdotti();
            List<CreateOrderResource> orderResource = new List<CreateOrderResource>();
            foreach (var prodotto in prodotti)
            {
                orderResource.Add(_mapper.Map<Prodotto, CreateOrderResource>(prodotto));

            }
            foreach (var order in orderResource)
            {
                order.Id = i;
                order.IdCliente = Id;
                i++;
            }
            return View(orderResource);
        }
        [HttpPost]
        public IActionResult CreateOrder(List<CreateOrderResource> prodotti)
        {
            _homeRepository.CreateOrder(prodotti);
            _unitOfWork.CompleteAsync();
            return RedirectToAction("Index", "Home", new { area = "AreaPersona", id = prodotti[0].IdCliente });

        }
        public IActionResult GetOrder([FromRoute] int id)
        {
            List<int> ordiniId = (List<int>)_homeRepository.GetOrder(id);

            return View(ordiniId);
        }
        public IActionResult ViewOrder([FromRoute]int id)
        {
            var ordineResult = _homeRepository.GetOrdineView(id);

            var ordineView = _mapper.Map<Ordine, OrdineResourceView>(ordineResult);

            return View(ordineView);
        }
        public IActionResult DeleteOrder([FromRoute]int id)
        {
            _homeRepository.DeleteOrder(id)
            //prendere id persona dall'ordine e reindirazzare agl ordini lista
         }
    }
}