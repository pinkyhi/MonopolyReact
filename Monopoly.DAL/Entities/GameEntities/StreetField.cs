namespace Monopoly.DAL.Entities.GameEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

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
    }
}