namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.JoinEntities;

    [AutoMap(typeof(CityEventField))]
    public class CityEventFieldModel : BaseEntityModel
    {
        public int CityId { get; set; }

        public int EventFieldId { get; set; }

        public EventFieldModel EventField { get; set; }

        public string DefaultArguments { get; set; }

        public int Position { get; set; }

        public string Title { get; set; }
    }
}