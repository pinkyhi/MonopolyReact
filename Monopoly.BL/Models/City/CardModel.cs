namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities.Cards;

    [AutoMap(typeof(EventCard))]
    public class CardModel : BaseEntityModel
    {
        public string Name { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }

        public string Message { get; set; }

        public int CardGroupId { get; set; }
    }
}