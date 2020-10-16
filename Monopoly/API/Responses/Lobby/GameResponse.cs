namespace Monopoly.API.Responses.Lobby
{
    using Monopoly.API.ViewModels;

    public class GameResponse
    {
        public GameViewModel Game { get; set; }

        public GameSettingsViewModel Settings { get; set; }
    }
}