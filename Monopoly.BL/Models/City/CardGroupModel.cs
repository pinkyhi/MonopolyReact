namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.GameEntities.Cards;

    [AutoMap(typeof(CardGroup))]
    public class CardGroupModel
    {
        public int Id { get; set; }

        public string DefaultName { get; set; }

        public string Title { get; set; }
    }
}