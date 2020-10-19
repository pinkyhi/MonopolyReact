namespace Monopoly.API.Responses
{
    using AutoMapper;
    using Monopoly.WebServices.Results;

    [AutoMap(typeof(AuthentificationResult))]
    public class AuthSuccessResponse
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }
    }
}