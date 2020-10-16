namespace Monopoly.API.ViewModels
{
    public class GameViewModel
    {
        public int GameId { get; set; }

        public string Title { get; set; }

        public int GameStatus { get; set; }

        public bool Password { get; set; }

        public int CountNow { get; set; }

        public int Capacity { get; set; }

        public string OwnerName { get; set; }
    }
}