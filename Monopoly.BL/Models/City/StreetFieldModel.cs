namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities;

    [AutoMap(typeof(StreetField))]
    public class StreetFieldModel : BaseEntityModel
    {
        public string DefaultName { get; set; }

        public int UnbuildedTax { get; set; }

        public int OneHouseTax { get; set; }

        public int TwoHouseeTax { get; set; }

        public int ThreeHousesTax { get; set; }

        public int FourHousesTax { get; set; }

        public int HotelTax { get; set; }

        public int StreetMonopolyId { get; set; }

        public StreetMonopolyModel StreetMonopoly { get; set; }
    }
}