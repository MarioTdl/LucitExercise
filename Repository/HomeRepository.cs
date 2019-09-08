
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Controllers.Resource;
using esercizioUnikey.Core;
using esercizioUnikey.Core.Model;
using esercizioUnikey.Interfaccia;
using esercizioUnikey.Repository.Interfaccia;
using Microsoft.EntityFrameworkCore;

namespace esercizioUnikey.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly DbContextUnikey _context;
        private readonly IMapper _mapper;

        public HomeRepository(DbContextUnikey context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }

        public KeyValueResource RedirectToArea(string email, string password)
        {
            KeyValueResource ritorno;

            if (_context.Persone.Where(x => x.Email == email && x.Password == password).FirstOrDefault() != null)
                ritorno = new KeyValueResource { id = _context.Persone.Where(x => x.Email == email && x.Password == password).FirstOrDefault().Id, areaRitorno = "Persona" };
            else
                ritorno = new KeyValueResource { id = _context.Aziende.Where(x => x.Email == email && x.Password == password).FirstOrDefault().Id, areaRitorno = "Azienda" };

            return ritorno;
        }

        public Persona GetPersona(int id)
        {
            var personaDb = _context.Persone.Find(id);
            return personaDb;
        }

        public IEnumerable<Prodotto> GetProdotti()
        {
            var prodotti = _context.Prodotti.ToList();
            return prodotti;
        }

        public void CreateOrder(List<CreateOrderResource> prodotti)
        {
            var listaProdottiOrdine = prodotti.Where(x => x.Selected == true).ToList();
            Ordine ordineAdd = new Ordine();
            ordineAdd.DataCreazione = DateTime.Now;
            ordineAdd.PersonaId = listaProdottiOrdine[0].IdCliente;
            foreach (var prodotto in listaProdottiOrdine)
            {
                ordineAdd.Prodotti.Add(_mapper.Map<CreateOrderResource, Prodotto>(prodotto));
            }

            _context.Ordini.Add(ordineAdd);

        }
        public IEnumerable<int> GetOrder(int id)
        {
            return _context.Ordini.Where(x => x.PersonaId == id).Select(x => x.Id).ToList();
        }

        public Ordine GetOrdineView(int id)
        {
            var a = _context.Ordini.Where(x => x.Id == id).Include(x => x.Prodotti).FirstOrDefault();

            return a;

        }
    }
}