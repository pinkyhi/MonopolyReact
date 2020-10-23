namespace Monopoly.DAL.Entities.JoinEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.GameEntities.Cards;

    public class CityCard : BaseEntity
    {
        public int CityId { get; set; }

        public City City { get; set; }

        public int CardId { get; set; }

        public EventCard EventCard { get; set; }

        public string Arguments { get; set; }

        public IEnumerable<GameCard> GameCards { get; set; }
    }
}