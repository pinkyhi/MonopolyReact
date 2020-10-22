namespace Monopoly.DAL.Entities.GameEntities.Groups
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;

    public class StreetMonopoly : BaseEntity
    {
        public string Title { get; set; }

        public string Color { get; set; }

        public IEnumerable<StreetField> Streets { get; set; }
    }
}