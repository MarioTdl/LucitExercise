using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace esercizioUnikey.Core.Model
{
    [Table("Company")]
    public class Company : BaseUser
    {
        public DateTime DataDiFondazione { get; set; }
        public TechType TechType { get; set; }
        public ICollection<Dipendente> Dipendenti { get; set; }
        public Company()
        {
            Dipendenti = new Collection<Dipendente>();
        }
    }
}