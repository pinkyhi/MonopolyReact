namespace Monopoly.Mapper
{
    using AutoMapper;
    using Monopoly.BL.Models;
    using Monopoly.DAL.Entities;

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<Game, GameModel>()
                .ForMember(g => g.Password, e => e.MapFrom(o => !string.IsNullOrEmpty(o.Password)))
                .ForMember(g => g.GameId, e => e.MapFrom(o => o.Id))
                .ForMember(g => g.CityName, e => e.MapFrom(o => o.City.Name))
                .ForMember(g => g.OwnerName, e => e.MapFrom(o => o.GameOwner.UserName));
        }
    }
}