namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.GameEntities.Groups;

    [AutoMap(typeof(StreetMonopoly))]
    public class StreetMonopolyModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Color { get; set; }
    }
}