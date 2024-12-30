using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _14.week_02_PRATIK_Identity.Models
{
    public class User : IdentityUser
    {
        public string PasswordHash { get; set; }  // Şifre hash'i
    }
}
