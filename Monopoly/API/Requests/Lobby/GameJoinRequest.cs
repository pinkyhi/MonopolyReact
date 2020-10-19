namespace Monopoly.API.Requests.Lobby
{
    using AutoMapper;
    using Monopoly.BL.Contracts;

    [AutoMap(typeof(GameJoinContract), ReverseMap = true)]
    public class GameJoinRequest
    {
        public int GameId { get; set; }

        public string Password { get; set; }
    }
}