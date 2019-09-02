using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace esercizioUnikey.Core.Model
{
    [Table("Prodotto")]
    public class Prodotto
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Prezzo { get; set; }
        public int OrdineId { get; set; }
        public Ordine Ordine { get; set; }
    }
}