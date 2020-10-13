namespace Monopoly.DAL.Entities.GameEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.GameEntities.Groups;
    using Monopoly.DAL.Entities.JoinEntities;

    public class StreetField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int UnbuildedTax { get; set; }

        public int OneHouseTax { get; set; }

        public int TwoHouseeTax { get; set; }

        public int ThreeHousesTax { get; set; }

        public int FourHousesTax { get; set; }

        public int HotelTax { get; set; }

        public int StreetMonopolyId { get; set; }

        public StreetMonopoly StreetMonopoly { get; set; }

        public IEnumerable<CityStreet> CityStreets { get; set; }
    }
}