namespace Monopoly.BL.Contracts
{
    using System.ComponentModel.DataAnnotations;

    public class GameCreateContract
    {
        [MaxLength(32)]
        public string Title { get; set; }

        [Required]
        public int SettingsId { get; set; }

        public int CityId { get; set; }

        [Range(0, 6)]
        public int Capacity { get; set; }

        [MaxLength(16)]
        public string Password { get; set; }

        public string GameOwnerId { get; set; }
    }
}