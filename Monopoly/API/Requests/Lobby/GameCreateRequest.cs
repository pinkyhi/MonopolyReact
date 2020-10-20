namespace Monopoly.API.Requests.Lobby
{
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Monopoly.BL.Contracts;

    [AutoMap(typeof(GameCreateContract), ReverseMap = true)]
    public class GameCreateRequest
    {
        [MaxLength(32)]
        public string Title { get; set; }

        public int? SettingsId { get; set; }

        public int? CityId { get; set; }

        [Range(2, 6)]
        public int Capacity { get; set; }

        [MaxLength(16)]
        public string Password { get; set; }
    }
}