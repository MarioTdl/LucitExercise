using System.Collections.Generic;
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
            CreateMap<Prodotto, CreateOrderResource>()
            .ForMember(x => x.Nome, opt => opt.MapFrom(m => m.Nome))
            .ForMember(x => x.Prezzo, opt => opt.MapFrom(m => m.Prezzo));
            CreateMap<Ordine, OrdineResource>()
            .ForMember(x => x.Id, opt => opt.MapFrom(id => id.Id));

            //RESOURCE SU ENTITA
            CreateMap<PersonaResource, Persona>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<CreateOrderResource, Prodotto>()
          .ForMember(x => x.Nome, opt => opt.MapFrom(m => m.Nome))
          .ForMember(x => x.Prezzo, opt => opt.MapFrom(m => m.Prezzo));


        }
    }
}