namespace Monopoly.DAL.Entities.GameEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class EventField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }

        public IEnumerable<CityEventField> CityEventFields { get; set; }
    }
}