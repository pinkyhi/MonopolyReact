namespace Monopoly.Mapper
{
    using AutoMapper;
    using Monopoly.API.Responses;
    using Monopoly.WebServices.Results;

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<AuthentificationResult, AuthSuccessResponse>();
        }
    }
}