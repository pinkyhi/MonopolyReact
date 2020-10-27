namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities;

    [AutoMap(typeof(EventField))]
    public class EventFieldModel : BaseEntityModel
    {
        public string DefaultName { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }
    }
}