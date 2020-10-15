namespace Monopoly.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;
    using Monopoly.WebServices.Interfaces;

    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(MonopolyExceptionFilterAttribute))]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService identityService;
        private readonly IMapper mapper;

        public IdentityController(IIdentityService identityService, IMapper mapper)
        {
            this.identityService = identityService;
            this.mapper = mapper;
        }


    }
}