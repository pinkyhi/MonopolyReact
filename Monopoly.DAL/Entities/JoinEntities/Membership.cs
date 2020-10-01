namespace Monopoly.DAL.Entities.JoinEntities
{
    public class Membership
    {
        public string UserId { get; set; }

        public int GameId { get; set; }

        public int Order { get; set; }

        public int UserStatus { get; set; }

        public int PlayerStatus { get; set; }

        public int Position { get; set; }

        public int Money { get; set; }
    }
}