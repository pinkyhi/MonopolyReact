namespace Monopoly.Hubs
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;
    using Monopoly.API.ViewModels;
    using Monopoly.Core.Resources;

    public class LobbyHub : Hub
    {
        public Task LobbyGame(GameViewModel gameModel)
        {
            return this.Clients.All.SendAsync(HubStrings.LobbyGame, gameModel);
        }
    }
}