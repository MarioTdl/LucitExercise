using esercizioUnikey.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace esercizioUnikey.Core
{
    public class DbContextUnikey : DbContext
    {
        public DbSet<Persona> Persone{get;set;}
        public DbSet<Company> Aziende{get;set;}
        public DbSet<Dipendente> Dipendenti{get;set;}
         public DbSet<Ordine> Ordini{get;set;}
         public DbSet<Prodotto> Prodotti{get;set;}

        public DbContextUnikey (DbContextOptions<DbContextUnikey> options)
         :base(options)
        {

        }
    }
}