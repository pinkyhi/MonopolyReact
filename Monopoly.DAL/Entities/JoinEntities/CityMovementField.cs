namespace Monopoly.DAL.Entities.JoinEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.GameEntities;

    public class CityMovementField : BaseEntity
    {
        public int CityId { get; set; }

        public City City { get; set; }

        public int MovementFieldId { get; set; }

        public MovementField MovementField { get; set; }

        public int Price { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }

        public IEnumerable<GameMovementField> GameMovementFields { get; set; }
    }
}