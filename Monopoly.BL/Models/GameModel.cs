namespace Monopoly.BL.Models
{
    using AutoMapper;
    using AutoMapper.Configuration.Annotations;
    using Monopoly.DAL.Entities;

    [AutoMap(typeof(Game))]
    public class GameModel
    {
        public int GameId { get; set; }

        public string Title { get; set; }

        public int GameStatus { get; set; }

        public bool Password { get; set; }

        public int CountNow { get; set; }

        public int Capacity { get; set; }

        public string OwnerName { get; set; }

        public int? CityId { get; set; }

        [SourceMember(nameof(Game.City) + "." + nameof(City.Name))]
        public string CityName { get; set; }
    }
}