namespace Monopoly.DAL.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        [Required]
        public DateTime RegistrationDate { get; set; }
    }
}