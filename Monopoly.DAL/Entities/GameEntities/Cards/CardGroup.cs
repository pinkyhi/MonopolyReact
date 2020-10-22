namespace Monopoly.DAL.Entities.GameEntities.Cards
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class CardGroup : BaseEntity
    {
        public string DefaultName { get; set; }

        public string Title { get; set; }

        public IEnumerable<CityCard> CityCards { get; set; }
    }
}