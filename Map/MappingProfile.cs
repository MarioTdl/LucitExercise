using AutoMapper;
using esercizioUnikey.Areas.AreaPersona.Controllers.Resource;
using esercizioUnikey.Core;
using esercizioUnikey.Core.Model;

namespace esercizioUnikey.Map
{
    public class MappingProfile : Profile
    {
        private readonly DbContextUnikey _db;
        public MappingProfile(DbContextUnikey db) { _db = db; }
        public MappingProfile()
        {
            //ENTITA SU RESOURCE
            CreateMap<Persona, PersonaResource>();

            //RESOURCE SU ENTITA
            CreateMap<PersonaResource, Persona>()
            .ForMember(v => v.Id, opt => opt.Ignore());
        }
    }
}