namespace Monopoly.Filters.ActionFilters
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Monopoly.API.Responses;
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class ModelValidationAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(new ErrorResponse
                {
                    Message = ErrorMessages.BadModelData,
                    Errors = context.ModelState.Values.SelectMany(e => e.Errors),
                    SubCode = (int)ErrorCodesEnums.Global.ModelError
                });
            }
        }
    }
}