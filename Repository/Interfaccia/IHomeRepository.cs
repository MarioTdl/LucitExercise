using esercizioUnikey.Controllers.Resource;

namespace esercizioUnikey.Repository.Interfaccia
{
    public interface IHomeRepository
    {
        KeyValueResource RedirectToArea(string email, string password);
    }
}