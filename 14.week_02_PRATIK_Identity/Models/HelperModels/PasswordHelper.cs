using Microsoft.AspNetCore.Identity;

namespace _14.week_02_PRATIK_Identity.Models.HelperModels
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            var passwordHasher = new PasswordHasher<object>();
            return passwordHasher.HashPassword(null, password);
        }
    }
}
