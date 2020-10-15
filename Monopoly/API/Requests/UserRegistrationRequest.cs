﻿namespace Monopoly.API.Requests
{
    using System.ComponentModel.DataAnnotations;

    public class UserRegistrationRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(5)]
        [MaxLength(60)]
        public string UserName { get; set; }

        [MinLength(5)]
        [MaxLength(60)]
        public string Password { get; set; }
    }
}