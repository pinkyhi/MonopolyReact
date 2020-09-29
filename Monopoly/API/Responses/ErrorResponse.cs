namespace Monopoly.API.Responses
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class ErrorResponse
    {
        public int SubCode { get; set; }

        public string Message { get; set; }

        public IEnumerable<ModelError> Errors { get; set; }
    }
}