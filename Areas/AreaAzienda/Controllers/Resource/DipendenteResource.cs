using System;

namespace esercizioUnikey.Areas.AreaAzienda.Controllers.Resource
{
    public class DipendenteResource
    {
        public int Id { get; set; }
        public DateTime DataAssunzione { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
    }
}