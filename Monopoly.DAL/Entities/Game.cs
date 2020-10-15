namespace Monopoly.DAL.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Monopoly.DAL.Entities.BaseEntities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class Game : BaseEntity
    {
        [MaxLength(32)]
        public string Title { get; set; }

        [Range(0, 6)]
        public int Capacity { get; set; }

        public int SettingsId { get; set; }

        public GameSettings GameSettings { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public int GameStatus { get; set; }

        public int? TurnOwnerId { get; set; }

        public Membership TurnOwner { get; set; }

        public string GameOwnerId { get; set; }

        public User GameOwner { get; set; }

        [MaxLength(16)]
        public string Password { get; set; }

        public IEnumerable<Membership> Membership { get; set; }

        public IEnumerable<GameCard> Cards { get; set; }

        public IEnumerable<GameStreet> Streets { get; set; }

        public IEnumerable<GameEventField> EventFields { get; set; }

        public IEnumerable<GameMovementField> MovementFields { get; set; }

        public IEnumerable<GameMultiplyField> MultiplyFields { get; set; }
    }
}