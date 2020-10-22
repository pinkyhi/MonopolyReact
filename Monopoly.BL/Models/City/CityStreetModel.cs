namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.JoinEntities;

    [AutoMap(typeof(CityStreet))]
    public class CityStreetModel
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public int StreetId { get; set; }

        public StreetFieldModel Street { get; set; }

        public int Price { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}