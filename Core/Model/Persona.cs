using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace esercizioUnikey.Core.Model
{
    [Table("Persona")]
    public class Persona : BaseUser
    {
        public string Indirizzo { get; set; }
        public string Azienda { get; set; }
        public ICollection<Ordine> Ordini { get; set; }
        public Persona()
        {
            Ordini = new Collection<Ordine>();
        }
    }
}