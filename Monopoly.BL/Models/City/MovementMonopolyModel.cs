namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities.Groups;

    [AutoMap(typeof(MovementMonopoly))]
    public class MovementMonopolyModel : BaseEntityModel
    {
        public string Name { get; set; }

        public int BaseTax { get; set; }

        public double MonopolyMultiplier { get; set; }

        public double IterationDivider { get; set; }
    }
}