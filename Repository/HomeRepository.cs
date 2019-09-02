using System;
using System.Linq;
using esercizioUnikey.Core;
using esercizioUnikey.Repository.Interfaccia;

namespace esercizioUnikey.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly DbContextUnikey _context;
        public HomeRepository(DbContextUnikey context)
        {
            _context = context;
        }

        public string RedirectToArea(string email, string password)
        {
            string areaRitorno = String.Empty;

            if (_context.Persone.Where(x => x.Email == email && x.Password == password) == null)
                areaRitorno = "isPerson";

            if (String.IsNullOrEmpty(areaRitorno))
                areaRitorno = "isCompany";

            return (areaRitorno == "isPerson") ? "Persona" : "Azienda";

        }

    }
}