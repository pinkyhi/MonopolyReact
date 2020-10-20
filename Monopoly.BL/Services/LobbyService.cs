namespace Monopoly.BL.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Monopoly.BL.Contracts;
    using Monopoly.BL.Interfaces;
    using Monopoly.BL.Models;
    using Monopoly.BL.Results;
    using Monopoly.Core.Enums;
    using Monopoly.Core.Exceptions.Lobby;
    using Monopoly.DAL.Entities;
    using Monopoly.DAL.Entities.JoinEntities;
    using Monopoly.DAL.Interfaces;

    public class LobbyService : ILobbyService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public LobbyService(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<GameResult> CreateGame(GameCreateContract game)
        {
            Game newGame = this.mapper.Map<Game>(game);
            newGame.GameStatus = (int)GameStatusesEnum.New;
            newGame = await this.repository.AddAsync(newGame);
            await this.AddNewPlayer(newGame, game.GameOwnerId, newGame.Capacity);

            Game gameFinal = await this.repository.GetAsync<Game>(false, g => g.Id == newGame.Id, g => g.City, g => g.GameSettings);
            GameResult result = new GameResult()
            {
                Game = this.mapper.Map<GameModel>(gameFinal),
                Settings = this.mapper.Map<GameSettingsModel>(gameFinal.GameSettings)
            };

            return result;
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

        private async Task AddNewPlayer(Game game, string userId, int capacity, int playerStatus = (int)PlayerStatusesEnum.InLobby)
        {
            int countOfPlayers = await this.CheckCountOfPlayers(game.Id);
            if (countOfPlayers < capacity)
            {
                Membership membership = new Membership()
                {
                    GameId = game.Id,
                    UserId = userId,
                    PlayerStatus = playerStatus
                };
                if (game.Membership == null)
                {
                    game.Membership = new List<Membership>();
                }

                game.Membership.Append(membership);
                await this.repository.UpdateAsync(game);
            }
            else
            {
                throw new GameIsFullException();
            }
        }

        private async Task<int> CheckCountOfPlayers(int gameId)
        {
            Game game = await this.repository.GetAsync<Game>(false, g => g.Id == gameId, g => g.Membership);
            return game.Membership.Count();
        }
    }
}