namespace Monopoly.DAL.Entities.GameEntities.Cards
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;

    public class CardGroup : BaseEntity
    {
        public string DefaultName { get; set; }

        public string Title { get; set; }

        public IEnumerable<EventCard> Cards { get; set; }
    }
}