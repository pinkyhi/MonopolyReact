namespace Monopoly.API.Responses.Lobby
{
    using System.Collections.Generic;
    using Monopoly.API.ViewModels;

    public class LobbyGamesResponse
    {
        IEnumerable<LobbyGameViewModel> Games { get; set; }
    }
}