namespace Monopoly.BL.Models.City
{
    public class CityEventFieldModel
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public int EventFieldId { get; set; }

        public EventFieldModel EventField { get; set; }

        public string DefaultArguments { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}