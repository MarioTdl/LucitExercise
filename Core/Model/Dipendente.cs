using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace esercizioUnikey.Core.Model
{
    [Table("Dipendente")]
    public class Dipendente
    {
        public int Id { get; set; }
        public DateTime DataAssunzione { get; set; }
        [Required]
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }

}