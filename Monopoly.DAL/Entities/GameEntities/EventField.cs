namespace Monopoly.DAL.Entities.GameEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class EventField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }
    }
}