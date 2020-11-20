namespace Monopoly.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.SignalR;
    using Monopoly.API.Requests.Lobby;
    using Monopoly.API.Responses.Lobby;
    using Monopoly.API.ViewModels;
    using Monopoly.BL.Contracts;
    using Monopoly.BL.Interfaces;
    using Monopoly.BL.Models;
    using Monopoly.BL.Results;
    using Monopoly.Core.Resources;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;
    using Monopoly.Hubs;

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(MonopolyExceptionFilterAttribute))]
    public class LobbyController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IHubContext<LobbyHub> hubContext;
        private readonly ILobbyService lobbyService;

        public LobbyController(IMapper mapper, IHubContext<LobbyHub> hubContext, ILobbyService lobbyService)
        {
            this.hubContext = hubContext;
            this.mapper = mapper;
            this.lobbyService = lobbyService;
        }

        [HttpGet(API.Routes.DefaultRoutes.Lobby.GetGames)]
        public async Task<IActionResult> LobbyGames(string searchPart)
        {
            LobbyGamesResponse response = new LobbyGamesResponse();
            IEnumerable<GameModel> gamesResult = await this.lobbyService.GetLobbyGames(searchPart);
            response.Games = gamesResult.Select(x => this.mapper.Map<GameViewModel>(x));
            return this.Ok(response);
        }

        [HttpPost(API.Routes.DefaultRoutes.Lobby.GameJoin)]
        public async Task<IActionResult> GameJoin([FromBody] GameJoinRequest request)
        {
            GameJoinContract joinContract = this.mapper.Map<GameJoinContract>(request);

            var userId = this.User.Claims.First(c => c.Type == StringConstants.JwtClaimId).Value;
            joinContract.UserId = userId;
            await this.lobbyService.JoinGame(joinContract);
            return this.Ok();
        }

        [HttpPut(API.Routes.DefaultRoutes.Lobby.GameCreate)]
        public async Task<IActionResult> GameCreate([FromBody] GameCreateRequest request)
        {
            GameCreateContract createContract = this.mapper.Map<GameCreateContract>(request);

            var userId = this.User.Claims.First(c => c.Type == StringConstants.JwtClaimId).Value;
            createContract.GameOwnerId = userId;
            GameResult result = await this.lobbyService.CreateGame(createContract);
            return this.Ok(this.mapper.Map<GameResponse>(result));
        }

        [HttpPatch(API.Routes.DefaultRoutes.Lobby.GameLeave)]
        public async Task<IActionResult> GameLeave([FromBody] GameLeaveRequest request)
        {
            GameLeaveContract leaveContract = this.mapper.Map<GameLeaveContract>(request);

            var userId = this.User.Claims.First(c => c.Type == StringConstants.JwtClaimId).Value;
            leaveContract.UserId = userId;
            await this.lobbyService.LeaveGame(leaveContract);
            return this.Ok();
        }
    }
}