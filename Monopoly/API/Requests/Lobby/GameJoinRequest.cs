namespace Monopoly.API.Requests.Lobby
{
    public class GameJoinRequest
    {
        public int GameId { get; set; }

        public string Password { get; set; }
    }
}