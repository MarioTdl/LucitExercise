using System.Collections.Generic;
using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Controllers.Resource;
using esercizioUnikey.Core.Model;

namespace esercizioUnikey.Repository.Interfaccia
{
    public interface IHomeRepository
    {
        Persona GetPersona(int id);
        IEnumerable<Prodotto> GetProdotti();
        KeyValueResource RedirectToArea(string email, string password);
        void CreateOrder(List<CreateOrderResource> prodotti);
        IEnumerable<int> GetOrder(int id);
        Ordine GetOrdineView(int id);
        int GetIdPersona(int id);
        void DeleteOrder(int id);
        Company GetCompany(int id);
        void AddDipendente(Dipendente dipendente);
        IEnumerable<Dipendente> GetDipendenti(int id);
        void DeleteDipendente(int id);
    }
}