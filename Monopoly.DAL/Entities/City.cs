namespace Monopoly.DAL.Entities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class City : BaseEntity
    {
        public string Name { get; set; }

        public bool Publicity { get; set; }

        public IEnumerable<Game> Games { get; set; }

        public IEnumerable<CityCard> CityCards { get; set; }

        public IEnumerable<CityStreet> CityStreets { get; set; }

        public IEnumerable<CityMultiplyField> CityMultiplyFields { get; set; }

        public IEnumerable<CityMovementField> CityMovementFields { get; set; }

        public IEnumerable<CityEventField> CityEventFields { get; set; }
    }
}