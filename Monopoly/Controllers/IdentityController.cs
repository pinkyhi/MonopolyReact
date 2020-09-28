using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Monopoly.Filters.ActionFilters;

namespace Monopoly.Controllers
{
    [ApiController]
    [ModelValidation]
    [ServiceFilter(typeof(GuessNumberExceptionsFilterAttribute))]
    public class IdentityController : ControllerBase
    {

    }
}
