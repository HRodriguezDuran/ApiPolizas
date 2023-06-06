using ApiPolizas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiPolizas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private IConfiguration config;

        public TokenController( IConfiguration config)
        {
            this.config = config;
        }


        [HttpPost]
        public string GetToken(User user)
        {

            if (user.Contrasena !="Simpson" && user.Usuario != "Homero" )
            {
                return "usuario incorrecto";

            }
            var token = GenerateToken();
            return token;
        }

        private string GenerateToken()
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "Homero"),
                new Claim(ClaimTypes.Email, "h@gmail.com")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("JWT:Key").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                claims : claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: cred);

            string token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;
                 
        }
    }
}
