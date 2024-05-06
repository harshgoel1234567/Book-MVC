using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer.Entity;
using Business_Layer.Services;
using System.Diagnostics.Eventing.Reader;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Business_Layer.Models;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Book_Backend.Controllers
{
    [ApiController]
     [Route("api/[controller]")]
    public class UserController : Controller
    {
        public readonly IRegisterService RegisterService;
        public UserController(IRegisterService registerService)
        {
            RegisterService = registerService;
        }
        private  string GenerateJwtToken(UserModel user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key=Encoding.ASCII.GetBytes("veryverysecret.....");
            
            var identity = new ClaimsIdentity(new Claim[]
            {
                
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Upn,user.Password),
             

            });
          
            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

  

            var tokenDescriptor = new SecurityTokenDescriptor
            { 
                Subject =identity,
                Expires= DateTime.UtcNow.AddDays(1), // Token expiration time
                SigningCredentials= credentials
             };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }




        [HttpPost]
        public IActionResult Register(UserModel user)
        {

            try
            {
                var s = RegisterService.Register(user);
                return Ok(s);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching the agreement by id");
            }
        }
        [HttpPost("Loginuser")]
        public IActionResult Login(Loginmodel login)
        {

            try
            {
                var s = RegisterService.check(login);
                if(s!=null)
                {
                    // Validate uvar secretKey =
                    //"YourSecretKey";ser credentials
                    var secretKey = "YourSecretKey";
                    var token = GenerateJwtToken(s);

                    return Ok(new
                    {
                        Token=token,
                        user=s,

                    });
                }
                else
                {
                    return Ok("false");
                }


            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
          
        }
    }

}
