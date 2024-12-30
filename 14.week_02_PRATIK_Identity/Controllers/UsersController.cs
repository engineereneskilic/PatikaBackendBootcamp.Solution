using _14.week_02_PRATIK_Identity.Data;
using _14.week_02_PRATIK_Identity.Models;
using _14.week_02_PRATIK_Identity.Models.HelperModels;
using _14.week_02_PRATIK_Identity.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _14.week_02_PRATIK_Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Şifreyi hashle
            var passwordHasher = new PasswordHasher<User>();
            var hashedPassword = passwordHasher.HashPassword(null, model.Password);

            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                PasswordHash = hashedPassword
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "User registered successfully" });

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserViewModel model)
        {
            // Model validasyonu yapılır
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Veritabanında email adresine göre kullanıcı bulunur
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            if (user == null)
                return Unauthorized(new { Message = "Invalid email or password" });

            // Şifre doğrulama yapılır
            var passwordHasher = new PasswordHasher<object>();
            var result = passwordHasher.VerifyHashedPassword(null, user.PasswordHash, model.Password);

            if (result == PasswordVerificationResult.Failed)
                return Unauthorized(new { Message = "Invalid email or password" });

            // Giriş başarılı, kullanıcıya bilgi döndürülür
            return Ok(new { Message = "Login successful", Email = user.Email });
        }

    }
}
