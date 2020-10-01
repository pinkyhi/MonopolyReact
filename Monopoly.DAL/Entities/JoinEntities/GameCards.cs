namespace Monopoly.DAL.Entities.JoinEntities
{
    public class GameCards
    {
        public int CityId { get; set; }

        public int CardId { get; set; }

        public int DeckPosition { get; set; }

        public string Arguments { get; set; }
    }
}