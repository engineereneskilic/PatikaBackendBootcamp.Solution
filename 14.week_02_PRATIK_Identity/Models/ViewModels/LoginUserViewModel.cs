using System.ComponentModel.DataAnnotations;

namespace _14.week_02_PRATIK_Identity.Models.ViewModels
{
    public class LoginUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
