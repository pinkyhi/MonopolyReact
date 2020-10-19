namespace Monopoly.API.Responses.Lobby
{
    using AutoMapper;
    using Monopoly.API.ViewModels;
    using Monopoly.BL.Results;

    [AutoMap(typeof(GameResult))]
    public class GameResponse
    {
        public GameViewModel Game { get; set; }

        public GameSettingsViewModel Settings { get; set; }
    }
}