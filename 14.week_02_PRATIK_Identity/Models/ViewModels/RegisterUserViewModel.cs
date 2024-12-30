using System.ComponentModel.DataAnnotations;

namespace _14.week_02_PRATIK_Identity.Models.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
