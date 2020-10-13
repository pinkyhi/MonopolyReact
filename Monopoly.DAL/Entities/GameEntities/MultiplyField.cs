namespace Monopoly.DAL.Entities.GameEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.GameEntities.Groups;
    using Monopoly.DAL.Entities.JoinEntities;

    public class MultiplyField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int MultiplyMonopolyId { get; set; }

        public MultiplyMonopoly MultiplyMonopoly { get; set; }

        public IEnumerable<CityMultiplyField> CityMultiplyFields { get; set; }
    }
}