namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.GameEntities;

    [AutoMap(typeof(EventField))]
    public class EventFieldModel
    {
        public int Id { get; set; }

        public string DefaultName { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }
    }
}