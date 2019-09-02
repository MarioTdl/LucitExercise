using System.Threading.Tasks;

namespace esercizioUnikey.Interfaccia
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}