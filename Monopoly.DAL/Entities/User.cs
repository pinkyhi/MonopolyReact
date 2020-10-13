namespace Monopoly.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using Monopoly.DAL.Entities.JoinEntities;

    public class User : IdentityUser
    {
        [Required]
        public DateTime RegistrationDate { get; set; }

        public IEnumerable<Membership> Membership { get; set; }
    }
}