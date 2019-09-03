using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Controllers.Resource;
using esercizioUnikey.Core.Model;

namespace esercizioUnikey.Repository.Interfaccia
{
    public interface IHomeRepository
    {
        Persona GetPersona(int id);
        KeyValueResource RedirectToArea(string email, string password);
    }
}