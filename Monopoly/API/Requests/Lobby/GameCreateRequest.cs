namespace Monopoly.API.Requests.Lobby
{
    using System.ComponentModel.DataAnnotations;

    public class GameCreateRequest
    {
        [MaxLength(32)]
        public string Title { get; set; }

        public int SettingsId { get; set; }

        public int CityId { get; set; }

        [Range(0, 6)]
        public int Capacity { get; set; }

        [MaxLength(16)]
        public string Password { get; set; }
    }
}