namespace Monopoly.DAL.Entities.JoinEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class GameStreet : BaseDto
    {
        public int GameId { get; set; }

        public Game Game { get; set; }

        public int StreetId { get; set; }

        public CityStreet Street { get; set; }

        public int? OwnerId { get; set; }

        public Membership Owner { get; set; }

        public int Level { get; set; }
    }
}