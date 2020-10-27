namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.JoinEntities;

    [AutoMap(typeof(CityMovementField))]
    public class CityMovementFieldModel : BaseEntityModel
    {
        public int CityId { get; set; }

        public int MovementFieldId { get; set; }

        public MovementFieldModel MovementField { get; set; }

        public int Price { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}