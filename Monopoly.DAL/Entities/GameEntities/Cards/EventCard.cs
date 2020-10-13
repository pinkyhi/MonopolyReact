namespace Monopoly.DAL.Entities.GameEntities.Cards
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class EventCard : BaseEntity
    {
        public string Name { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }

        public string Message { get; set; }

        public IEnumerable<CityCard> CityCards { get; set; }
    }
}