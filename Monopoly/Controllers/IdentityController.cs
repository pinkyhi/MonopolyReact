namespace Monopoly.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Monopoly.DAL.Entities;
    using Monopoly.DAL.Interfaces;
    using Monopoly.Filters.ActionFilters;
    using Monopoly.Filters.ExceptionFilters;

    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(MonopolyExceptionFilterAttribute))]
    public class IdentityController : ControllerBase
    {
        public IdentityController(IRepository repository)
        {
        }
    }
}