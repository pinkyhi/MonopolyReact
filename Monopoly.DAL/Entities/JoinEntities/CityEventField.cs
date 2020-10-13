namespace Monopoly.DAL.Entities.JoinEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.GameEntities;

    public class CityEventField : BaseEntity
    {
        public int CityId { get; set; }

        public City City { get; set; }

        public int EventFieldId { get; set; }

        public EventField EventField { get; set; }

        public string DefaultArguments { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }

        public IEnumerable<GameEventField> GameEventFields { get; set; }
    }
}