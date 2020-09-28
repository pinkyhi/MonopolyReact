using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monopoly.API.Responses
{
    public class ErrorResponse
    {
        public int SubCode { get; set; }

        public string Message { get; set; }

        public IEnumerable<ModelError> Errors { get; set; }
    }
}
