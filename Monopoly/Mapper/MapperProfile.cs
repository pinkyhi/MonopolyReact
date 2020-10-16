namespace Monopoly.Mapper
{
    using AutoMapper;
    using Monopoly.API.Responses;
    using Monopoly.API.Responses.Lobby;
    using Monopoly.API.ViewModels;
    using Monopoly.BL.Models;
    using Monopoly.BL.Results;
    using Monopoly.WebServices.Results;

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<AuthentificationResult, AuthSuccessResponse>();
            this.CreateMap<GameResult, GameResponse>();
            this.CreateMap<GameModel, GameViewModel>();
            this.CreateMap<GameSettingsModel, GameSettingsViewModel>();
        }
    }
}