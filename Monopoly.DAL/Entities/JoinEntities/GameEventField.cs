namespace Monopoly.DAL.Entities.JoinEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class GameEventField : BaseDto
    {
        public int GameId { get; set; }

        public Game Game { get; set; }

        public int EventFieldId { get; set; }

        public CityEventField EventField { get; set; }

        public int? OwnerId { get; set; }

        public Membership Owner { get; set; }

        public int Arguments { get; set; }
    }
}