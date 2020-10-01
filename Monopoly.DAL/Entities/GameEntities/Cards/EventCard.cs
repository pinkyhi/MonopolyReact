namespace Monopoly.DAL.Entities.GameEntities.Cards
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class EventCard : BaseEntity
    {
        public string Name { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }

        public string Message { get; set; }
    }
}