namespace Monopoly.Hubs.Services
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;

    public abstract class GroupHubService
    {
        private protected IHubContext<LobbyHub> HubContext { get; set; }

        public Task Enter(string groupName, string connectionId)
        {
            return this.HubContext.Groups.AddToGroupAsync(connectionId, groupName);
        }

        public Task LeaveGroup(string groupName, string connectionId)
        {
            return this.HubContext.Groups.RemoveFromGroupAsync(connectionId, groupName);
        }
    }
}