namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.BL.Models.City.CityBase;
    using Monopoly.DAL.Entities.JoinEntities;

    [AutoMap(typeof(CityCard))]
    public class CityCardModel : BaseEntityModel
    {
        public int CityId { get; set; }

        public int CardId { get; set; }

        public CardModel EventCard { get; set; }

        public int CardGroupId { get; set; }

        public CardGroupModel CardGroup { get; set; }

        public string Arguments { get; set; }
    }
}