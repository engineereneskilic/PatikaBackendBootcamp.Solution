using _14.week_01_IdentityApi.Models;
using _14.week_01_IdentityApi.ViewModels;
using _14.week_02_PRATIK_Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _14.week_01_IdentityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IConfiguration _configiration;

        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configiration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Ok(new {message = "Kayıt başarılı"});
                }

                return BadRequest(new { errors = result.Errors.Select(e => e.Description) });
            }

            return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,false);

                if (result.Succeeded)
                {
                    var token = Helper.Helper.GenerateJwtToken(model.Email, _configiration["Jwt:Key"], _configiration["Jwt:Issuer"], _configiration["Jwt:Audience"]);


                    return Ok(new { message = "Giriş Başarılı", token = token });
                } else
                {
                    return Unauthorized(new {message = "Kullanıcı adı veya Şifre Yanlış !"} );
                }

            }

            return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });

        }

        [HttpPost("createrole")]
        public async Task<IActionResult> CreateRole([FromBody] string roleName)
        {
            if(string.IsNullOrWhiteSpace(roleName))
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(roleName));
                if (result.Succeeded)
                {
                    return Ok(new {message = "rol oluşturuldu"});
                }
                else
                {
                    return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });

                }
            }
            return BadRequest(new {message = "Rol adı boş olamaz"} );
        }

        [HttpGet("roles")]
        public IActionResult GetRoles()
        {
            var roles = _roleManager.Roles.ToList();

            return Ok(roles);
        }

        [HttpPost("addrole")]
        public async Task<IActionResult> AddRole(AddToRoleModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if(user == null)
            {
                return NotFound(new {message = "Kullanıcı bulunamadı"});
            }

            if(!await _roleManager.RoleExistsAsync(model.RoleName))
            {
                return NotFound(new {message = "Rol Bulunamadı"});
            }

            var result = await _userManager.AddToRoleAsync(user, model.RoleName);
            if(result.Succeeded)
            {
                return Ok(new { message = "Rol eklendi" });
            }
            else
            {
                return BadRequest (new {errors = result.Errors.Select(e => e.Description)});
            }

        }

        [HttpGet("userroles/{userId}")]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return NotFound(new {message = "Kullanıcı bulunamadı"});
            }
            var roles = await _userManager.GetRolesAsync(user);

            return Ok(roles);
        }


    }
}
