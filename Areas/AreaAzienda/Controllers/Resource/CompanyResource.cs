using esercizioUnikey.Core.Model;

namespace esercizioUnikey.Areas.AreaAzienda.Resource
{
    public class CompanyResource
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ProfileType Profile { get; set; }
        public TechType TechType { get; set; }
    }
}