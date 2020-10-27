namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities.Groups;

    [AutoMap(typeof(MultiplyMonopoly))]
    public class MultiplyMonopolyModel : BaseEntityModel
    {
        public string Name { get; set; }

        public double BaseMultiplier { get; set; }

        public double MonopolyMultipier { get; set; }

        public double IterationDivider { get; set; }
    }
}