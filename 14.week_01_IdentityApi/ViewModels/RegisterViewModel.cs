using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _14.week_01_IdentityApi.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }


    }
}
