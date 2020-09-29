namespace Monopoly.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Monopoly.Filters.ActionFilters;

    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(GuessNumberExceptionsFilterAttribute))]
    public class IdentityController : ControllerBase
    {
    }
}