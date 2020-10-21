namespace Monopoly.BL.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Monopoly.BL.Contracts;
    using Monopoly.BL.Models;
    using Monopoly.BL.Results;

    public interface ILobbyService
    {
        public Task<IEnumerable<GameModel>> GetLobbyGames(string searchPart);

        public Task<GameResult> CreateGame(GameCreateContract gameContract);

        public Task<GameResult> JoinGame(GameJoinContract gameContract);

        public Task LeaveGame(GameLeaveContract gameContract);
    }
}