namespace Monopoly.DAL.Entities.JoinEntities
{
    public class CityStreets
    {
        public int CityId { get; set; }

        public int StreetId { get; set; }

        public int Price { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}