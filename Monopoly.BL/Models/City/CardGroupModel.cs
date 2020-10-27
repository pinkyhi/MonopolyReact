namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.GameEntities.Cards;

    [AutoMap(typeof(CardGroup))]
    public class CardGroupModel : BaseEntityModel
    {
        public string DefaultName { get; set; }

        public string Title { get; set; }
    }
}