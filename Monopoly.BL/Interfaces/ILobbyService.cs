namespace Monopoly.BL.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Monopoly.BL.Contracts;
    using Monopoly.BL.Models;
    using Monopoly.BL.Results;

    public interface ILobbyService
    {
        public IEnumerable<GameModel> GetLobbyGames();

        public Task<GameResult> CreateGame(GameCreateContract game);

        public GameResult JoinGame(GameJoinContract game);

        public void LeaveGame(GameLeaveContract game);
    }
}