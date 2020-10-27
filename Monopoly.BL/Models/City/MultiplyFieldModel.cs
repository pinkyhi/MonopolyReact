namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities;

    [AutoMap(typeof(MultiplyField))]
    public class MultiplyFieldModel : BaseEntityModel
    {
        public string DefaultName { get; set; }

        public int MultiplyMonopolyId { get; set; }

        public MultiplyMonopolyModel MultiplyMonopoly { get; set; }
    }
}