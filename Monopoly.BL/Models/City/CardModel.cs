namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.GameEntities.Cards;

    [AutoMap(typeof(EventCard))]
    public class CardModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int EventType { get; set; }

        public bool Choice { get; set; }

        public string Message { get; set; }

        public int CardGroupId { get; set; }
    }
}