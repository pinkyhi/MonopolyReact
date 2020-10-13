namespace Monopoly.DAL.Entities.GameEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.GameEntities.Groups;
    using Monopoly.DAL.Entities.JoinEntities;

    public class MovementField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int MovementMonopolyId { get; set; }

        public MovementMonopoly MovementMonopoly { get; set; }

        public IEnumerable<CityMovementField> CityMovementFields { get; set; }
    }
}