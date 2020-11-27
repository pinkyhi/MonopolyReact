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
    using Monopoly.DAL.Managers;

    public class LobbyService : ILobbyService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;
        private readonly UserManager userManager;

        public LobbyService(IRepository repository, IMapper mapper, UserManager userManager)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<GameResult> CreateGame(GameCreateContract game)
        {
            Game newGame = this.mapper.Map<Game>(game);
            newGame.GameStatus = (int)GameStatusesEnum.New;
            newGame = await this.repository.AddAsync(newGame);
            await this.AddNewPlayer(newGame, game.GameOwnerId, password: game.Password);

            Game gameFinal = await this.repository.GetAsync<Game>(false, g => g.Id == newGame.Id, g => g.City, g => g.GameSettings, g => g.Membership, g => g.GameOwner);
            GameResult result = new GameResult()
            {
                Game = this.mapper.Map<GameModel>(gameFinal),
                Settings = this.mapper.Map<GameSettingsModel>(gameFinal.GameSettings)
            };

            return result;
        }

        public async Task<IEnumerable<GameModel>> GetLobbyGames(string searchPart)
        {
            IEnumerable<Game> games;
            if (string.IsNullOrEmpty(searchPart))
            {
                games = await this.repository.GetRangeAsync<Game>(false, g => g.GameStatus == (int)GameStatusesEnum.New, g => g.City, g => g.GameOwner);
            }
            else
            {
                games = await this.repository.GetRangeAsync<Game>(false, g => g.GameStatus == (int)GameStatusesEnum.New && g.Title.ToLower().Contains(searchPart.Trim().ToLower()), g => g.City, g => g.GameOwner);
            }

            IEnumerable<GameModel> gameModels = games.Select(g => this.mapper.Map<GameModel>(g));
            return gameModels;
        }

        public async Task<GameResult> JoinGame(GameJoinContract gameContract)
        {
            Game game = await this.repository.GetAsync<Game>(false, g => g.Id == gameContract.GameId, g => g.Membership);
            await this.AddNewPlayer(game, gameContract.UserId, password: gameContract.Password);

            Game updatedGame = await this.repository.GetAsync<Game>(false, g => g.Id == gameContract.GameId);
            return this.mapper.Map<GameResult>(updatedGame);
        }

        public async Task LeaveGame(GameLeaveContract gameContract)
        {
            Game game = await this.repository.GetAsync<Game>(true, g => g.Id == gameContract.GameId, g => g.Membership);
            if (game.GameOwnerId.Equals(gameContract.UserId))
            {
                game.GameStatus = (int)GameStatusesEnum.OwnerLeaved;
                game.Membership.First(m => m.UserId == gameContract.UserId).PlayerStatus = (int)PlayerStatusesEnum.Leaved;
            }
            else
            {
                game.Membership.First(m => m.UserId == gameContract.UserId).PlayerStatus = (int)PlayerStatusesEnum.Leaved;
            }

            await this.repository.UpdateAsync(game);
        }

        private async Task AddNewPlayer(Game game, string userId, int playerStatus = (int)PlayerStatusesEnum.InLobby, string password = null)
        {
            int countOfPlayers = await this.CheckCountOfPlayers(game.Id);
            if (countOfPlayers < game.Capacity)
            {
                if (this.CheckGamePassword(game, password))
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
                    throw new GamePasswordException();
                }
            }
            else
            {
                throw new GameIsFullException();
            }
        }

        private bool CheckGamePassword(Game game, string password = null)
        {
            if (string.IsNullOrEmpty(game.Password))
            {
                return true;
            }
            else
            {
                return game.Password.Equals(password);
            }
        }

        private async Task<int> CheckCountOfPlayers(int gameId)
        {
            Game game = await this.repository.GetAsync<Game>(false, g => g.Id == gameId, g => g.Membership);
            return game.Membership.Count();
        }
    }
}