namespace Monopoly.BL.Contracts
{
    public class GameJoinContract
    {
        public int GameId { get; set; }

        public string Password { get; set; }

        public string UserId { get; set; }
    }
}