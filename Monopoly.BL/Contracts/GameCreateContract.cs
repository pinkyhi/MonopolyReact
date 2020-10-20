namespace Monopoly.BL.Contracts
{
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Monopoly.DAL.Entities;

    [AutoMap(typeof(Game), ReverseMap = true)]
    public class GameCreateContract
    {
        [MaxLength(32)]
        public string Title { get; set; }

        public int? SettingsId { get; set; }

        public int? CityId { get; set; }

        [Range(0, 6)]
        public int Capacity { get; set; }

        [MaxLength(16)]
        public string Password { get; set; }

        public string GameOwnerId { get; set; }
    }
}