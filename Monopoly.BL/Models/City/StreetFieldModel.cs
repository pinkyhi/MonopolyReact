namespace Monopoly.BL.Models.City
{
    public class StreetFieldModel
    {
        public int Id { get; set; }

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