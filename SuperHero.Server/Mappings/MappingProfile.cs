using AutoMapper;
using SuperHero.Server.DTO;
using SuperHero.Server.Models;
namespace SuperHero.Server.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hero, HeroDTO>();
            CreateMap<SuperPower, SuperPowerDTO>();
        }
    }
}
