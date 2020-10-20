namespace Monopoly.DAL.Entities.JoinEntities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;

    public class Membership : BaseEntity
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public int Order { get; set; }

        public int PlayerStatus { get; set; }

        public int TurnArgument { get; set; }

        public int Position { get; set; }

        public int Money { get; set; }

        public IEnumerable<Game> TurnOwnings { get; set; }

        public IEnumerable<GameCard> Cards { get; set; }

        public IEnumerable<GameStreet> Streets { get; set; }

        public IEnumerable<GameEventField> EventFields { get; set; }

        public IEnumerable<GameMovementField> MovementFields { get; set; }

        public IEnumerable<GameMultiplyField> MultiplyFields { get; set; }
    }
}