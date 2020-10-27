namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities.Groups;

    [AutoMap(typeof(StreetMonopoly))]
    public class StreetMonopolyModel : BaseEntityModel
    {
        public string Title { get; set; }

        public string Color { get; set; }
    }
}