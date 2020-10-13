namespace Monopoly.DAL.Entities.JoinEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class GameMovementField : BaseDto
    {
        public int GameId { get; set; }

        public Game Game { get; set; }

        public int MovementFieldId { get; set; }

        public CityMovementField MovementField { get; set; }

        public int? OwnerId { get; set; }

        public Membership Owner { get; set; }
    }
}