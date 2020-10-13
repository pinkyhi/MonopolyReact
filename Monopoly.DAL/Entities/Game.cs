namespace Monopoly.DAL.Entities
{
    using System.Collections.Generic;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class Game : BaseEntity
    {
        public int SettingsId { get; set; }

        public GameSettings GameSettings { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public int GameStatus { get; set; }

        public int TurnOwnerId { get; set; }

        public User TurnOwner { get; set; }

        public IEnumerable<Membership> Membership { get; set; }

        public IEnumerable<GameCard> Cards { get; set; }

        public IEnumerable<GameStreet> Streets { get; set; }

        public IEnumerable<GameEventField> EventFields { get; set; }

        public IEnumerable<GameMovementField> MovementFields { get; set; }

        public IEnumerable<GameMultiplyField> MultiplyFields { get; set; }
    }
}