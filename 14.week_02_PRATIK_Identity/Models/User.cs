using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _14.week_02_PRATIK_Identity.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
