using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace esercizioUnikey.Areas.AreaPersona.Controllers.Resource
{
    public class OrdineResourceView
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public DateTime DataCreazione { get; set; }
        public ICollection<ProdottoResource> Prodotti { get; set; }
        public OrdineResourceView()
        {
            Prodotti = new Collection<ProdottoResource>();
        }
    }
}