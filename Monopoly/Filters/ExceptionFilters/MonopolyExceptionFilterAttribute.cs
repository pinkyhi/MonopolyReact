namespace Monopoly.Filters.ExceptionFilters
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;
    using Monopoly.API.Responses;
    using Monopoly.Core.Enums;
    using Monopoly.Core.Exceptions;

    public class MonopolyExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private readonly ILogger<MonopolyExceptionFilterAttribute> logger;

        public MonopolyExceptionFilterAttribute(ILogger<MonopolyExceptionFilterAttribute> logger)
        {
            this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType().IsSubclassOf(typeof(BaseAppException)))
            {
                var exception = context.Exception;
                ObjectResult result = new ObjectResult(new ErrorResponse
                {
                    Message = exception.Message,
                    SubCode = (exception as BaseAppException).Code
                })
                {
                    StatusCode = StatusCodes.Status400BadRequest
                };

                context.Result = result;
            }
            else
            {
                this.logger.LogError(context.Exception.Message, context.Exception.StackTrace);

                context.Result = new ObjectResult(new ErrorResponse
                {
                    Message = context.Exception.Message,
                    SubCode = (int)ErrorCodesEnums.Global.Unknown
                })
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }

            context.ExceptionHandled = true;
        }
    }
}