namespace Monopoly.BL.Services
{
    using System.Collections.Generic;
    using Monopoly.BL.Contracts;
    using Monopoly.BL.Interfaces;
    using Monopoly.BL.Models;
    using Monopoly.BL.Results;
    using Monopoly.DAL.Interfaces;

    public class LobbyService : ILobbyService
    {
        private readonly IRepository repository;

        public LobbyService(IRepository repository)
        {
            this.repository = repository;
        }

        public GameResult CreateGame(GameCreateContract game)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GameModel> GetLobbyGames()
        {
            throw new System.NotImplementedException();
        }

        public GameResult JoinGame(GameJoinContract game)
        {
            throw new System.NotImplementedException();
        }

        public void LeaveGame(GameLeaveContract game)
        {
            throw new System.NotImplementedException();
        }
    }
}