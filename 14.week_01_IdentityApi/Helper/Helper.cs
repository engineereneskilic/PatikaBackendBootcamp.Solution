using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _14.week_01_IdentityApi.Helper
{
    public static class Helper
    {
        public static string GenerateJwtToken(string email, string key, string issuer, string audience, List<string> roles)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            var crediantals = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,email)
            };

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role,role)));

            var token = new JwtSecurityToken(issuer:issuer,audience:audience,claims:claims,expires:DateTime.Now.AddMinutes(30),
                signingCredentials:crediantals);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
