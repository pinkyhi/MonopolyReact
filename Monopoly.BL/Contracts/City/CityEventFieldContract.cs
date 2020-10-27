namespace Monopoly.BL.Contracts.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.JoinEntities;

    [AutoMap(typeof(CityEventField))]
    public class CityEventFieldContract
    {
        public int CityId { get; set; }

        public int EventFieldId { get; set; }

        public string DefaultArguments { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}