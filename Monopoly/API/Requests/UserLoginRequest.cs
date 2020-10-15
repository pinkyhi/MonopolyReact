namespace Monopoly.API.Requests
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;

    public class UserLoginRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        [NotNull]
        public string Password { get; set; }
    }
}