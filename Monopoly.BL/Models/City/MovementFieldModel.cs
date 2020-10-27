namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities;

    [AutoMap(typeof(MovementField))]
    public class MovementFieldModel : BaseEntityModel
    {
        public string DefaultName { get; set; }

        public int MovementMonopolyId { get; set; }

        public MovementMonopolyModel MovementMonopoly { get; set; }
    }
}