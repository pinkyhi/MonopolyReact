namespace Monopoly.BL.Models.City
{
    using System.Collections.Generic;
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities;

    [AutoMap(typeof(City))]
    public class CityModel : BaseEntityModel
    {
        public string Name { get; set; }

        public bool Publicity { get; set; }

        public IEnumerable<CityCardModel> CityCards { get; set; }

        public IEnumerable<CityStreetModel> CityStreets { get; set; }

        public IEnumerable<CityMultiplyFieldModel> CityMultiplyFields { get; set; }

        public IEnumerable<CityMovementFieldModel> CityMovementFields { get; set; }

        public IEnumerable<CityEventFieldModel> CityEventFields { get; set; }
    }
}