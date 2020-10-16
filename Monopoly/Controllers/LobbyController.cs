namespace Monopoly.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Monopoly.API.Requests.Lobby;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;
    using System.Threading.Tasks;

    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(MonopolyExceptionFilterAttribute))]
    public class LobbyController : ControllerBase
    {
        private readonly IMapper mapper;

        public LobbyController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet(API.Routes.DefaultRoutes.Lobby.GetGames)]
        public async Task<IActionResult> LobbyGames([FromBody] GetLobbyGamesRequest request)
        {
            return this.Ok();
        }

        [HttpGet(API.Routes.DefaultRoutes.Lobby.GameJoin)]
        public async Task<IActionResult> GameJoin([FromBody] GameJoinRequest request)
        {
            return this.Ok();
        }

        [HttpGet(API.Routes.DefaultRoutes.Lobby.GameCreate)]
        public async Task<IActionResult> GameCreate([FromBody] GameCreateRequest request)
        {
            return this.Ok();
        }

        [HttpGet(API.Routes.DefaultRoutes.Lobby.GameLeave)]
        public async Task<IActionResult> GameLeave([FromBody] GetLobbyGamesRequest request)
        {
            return this.Ok();
        }
    }
}