
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Controllers.Resource;
using esercizioUnikey.Core;
using esercizioUnikey.Core.Model;
using esercizioUnikey.Interfaccia;
using esercizioUnikey.Repository.Interfaccia;

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

    }
}