namespace Monopoly.Hubs.Services
{
    using Microsoft.AspNetCore.SignalR;
    using Monopoly.Hubs.Interfaces;

    public class LobbyHubService : GroupHubService, ILobbyHubService
    {
        public LobbyHubService(IHubContext<LobbyHub> hubContext)
        {
            this.HubContext = hubContext;
        }
    }
}