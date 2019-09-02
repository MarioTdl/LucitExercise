using System.Threading.Tasks;
using esercizioUnikey.Core;
using esercizioUnikey.Interfaccia;

namespace esercizioUnikey.Unit
{
    public class UOW : IUnitOfWork 
    {
        private readonly DbContextUnikey _context;
        public UOW(DbContextUnikey context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}