 namespace Monopoly.DAL.Entities.JoinEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class GameCard : BaseDto
    {
        public int GameId { get; set; }

        public Game Game { get; set; }

        public int CardId { get; set; }

        public CityCard Card { get; set; }

        public int DeckPosition { get; set; }

        public int? OwnerId { get; set; }

        public Membership Owner { get; set; }
    }
}