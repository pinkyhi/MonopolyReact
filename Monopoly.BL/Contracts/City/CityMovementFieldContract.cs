namespace Monopoly.BL.Contracts.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.JoinEntities;

    [AutoMap(typeof(CityMovementField))]
    public class CityMovementFieldContract
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public int MovementFieldId { get; set; }

        public int Price { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}