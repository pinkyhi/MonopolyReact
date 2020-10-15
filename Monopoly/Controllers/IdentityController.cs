namespace Monopoly.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;

    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(MonopolyExceptionFilterAttribute))]
    public class IdentityController : ControllerBase
    {
        public IdentityController()
        {
        }
    }
}