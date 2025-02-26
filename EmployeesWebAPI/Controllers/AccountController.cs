using System.IdentityModel.Tokens.Jwt;
using System.Text;
using EmployeesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(UserDetails user)
        { 
            if(user.Username == "Admin" &&  user.Password == "Admin123")
            {
                var secretKey = "abcdefghijklmnopqrstuvwxyz1234567890";
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

                var TokenParams = new JwtSecurityToken
                (
                    issuer: "Tavant",
                    audience: "Tavant",
                    expires: DateTime.Now.AddMinutes(3),
                    signingCredentials:new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
                );

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.WriteToken(TokenParams);

                return Ok(token);
            }
            else
            {
                return BadRequest("Invalid user credentials");
            }
        }
        
    }
}
