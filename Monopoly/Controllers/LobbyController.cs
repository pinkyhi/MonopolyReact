namespace Monopoly.Controllers
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.SignalR;
    using Monopoly.API.Requests.Lobby;
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

        public LobbyController(IMapper mapper, IHubContext<LobbyHub> hubContext)
        {
            this.hubContext = hubContext;
            this.mapper = mapper;
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
            return this.Ok();
        }

        [HttpPatch(API.Routes.DefaultRoutes.Lobby.GameLeave)]
        public async Task<IActionResult> GameLeave([FromBody] GetLobbyGamesRequest request)
        {
            return this.Ok();
        }
    }
}