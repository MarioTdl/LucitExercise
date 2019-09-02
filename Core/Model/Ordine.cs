using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace esercizioUnikey.Core.Model
{
    [Table("Ordine")]
    public class Ordine
    {
        public int Id { get; set; }
        public DateTime DataCreazione { get; set; }
        public ICollection<Prodotto> Prodotti { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public Ordine()
        {
            Prodotti = new Collection<Prodotto>();
        }
    }
}