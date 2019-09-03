using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using esercizioUnikey.Core.Model;

namespace esercizioUnikey.Areas.AreaPersona.Controllers.Resource
{
    public class PersonaResource
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public ProfileType Profile { get; set; }
        public string Indirizzo { get; set; }
        public string Azienda { get; set; }
        public ICollection<Ordine> Ordini { get; set; }
        public PersonaResource (){
            Ordini= new Collection<Ordine>();
        }
    }
}