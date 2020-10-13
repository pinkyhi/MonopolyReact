namespace Monopoly.DAL.Entities.JoinEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class GameMultiplyField : BaseDto
    {
        public int GameId { get; set; }

        public Game Game { get; set; }

        public int MultiplyFieldId { get; set; }

        public CityMultiplyField MultiplyField { get; set; }

        public int? OwnerId { get; set; }

        public Membership Owner { get; set; }
    }
}