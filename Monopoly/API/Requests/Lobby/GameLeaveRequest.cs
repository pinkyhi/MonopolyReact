namespace Monopoly.API.Requests.Lobby
{
    using AutoMapper;
    using Monopoly.BL.Contracts;

    [AutoMap(typeof(GameLeaveContract), ReverseMap = true)]
    public class GameLeaveRequest
    {
        public int GameId { get; set; }
    }
}