namespace Monopoly.Controllers
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.SignalR;
    using Monopoly.API.Requests.Lobby;
    using Monopoly.BL.Contracts;
    using Monopoly.BL.Interfaces;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;
    using Monopoly.Hubs;

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
        public async Task<IActionResult> LobbyGames([FromBody] GetLobbyGamesRequest request)
        {
            return this.Ok();
        }

        [HttpPost(API.Routes.DefaultRoutes.Lobby.GameJoin)]
        public async Task<IActionResult> GameJoin([FromBody] GameJoinRequest request)
        {
            return this.Ok();
        }

        [HttpPut(API.Routes.DefaultRoutes.Lobby.GameCreate)]
        public async Task<IActionResult> GameCreate([FromBody] GameCreateRequest request)
        {
            await this.lobbyService.CreateGame(this.mapper.Map<GameCreateContract>(request));
            return this.Ok();
        }

        [HttpPatch(API.Routes.DefaultRoutes.Lobby.GameLeave)]
        public async Task<IActionResult> GameLeave([FromBody] GetLobbyGamesRequest request)
        {
            return this.Ok();
        }
    }
}