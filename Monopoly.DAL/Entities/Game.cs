namespace Monopoly.DAL.Entities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class Game : BaseEntity
    {
        public int SettingId { get; set; }

        public int CityId { get; set; }

        public int GameStatus { get; set; }

        public int TurnOwnerId { get; set; }
    }
}