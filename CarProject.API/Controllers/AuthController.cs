using CarProject.API.DTOs;
using CarProject.API.Filters;
using CarProject.API.Models;
using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepo _repo;
        private AppSettings _settings;
        private IConfiguration _configuration;
        public AuthController(IAuthRepo repo, IOptionsSnapshot<AppSettings> appSettings, IConfiguration configuration)
        {
            _repo = repo;
            _settings = appSettings.Value;
            _configuration = configuration;
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistorDTO dto)
        {
            try
            {
                if (await _repo.UserExist(dto.UserName))
                {
                    ModelState.AddModelError("Error Username", "Kayıtlı kullanıcı");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var deger = new Kullanici()
                {
                    KullaniciAdi = dto.UserName
                };
                var eklenenKullanici = await _repo.Register(deger, dto.Password);
                return StatusCode(201);
            }
            catch (Exception ex)
            {

            }
            return NotFound();
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto)
        {
            try
            {
                var user = await _repo.Login(dto.UserName, dto.Password);
                if (user == null)
                {
                    return null;
                }
                var chr = _settings.Token;
                var key = Encoding.ASCII.GetBytes(_configuration.GetSection("AppSettings:Token").Value);
                var descripton = new SecurityTokenDescriptor()
                {
                    Expires = DateTime.Now.AddDays(1),
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.KullaniciId.ToString()),
                        new Claim(ClaimTypes.Name,user.KullaniciAdi)
                    }),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(descripton);
                var tokenDegeri = tokenHandler.WriteToken(token);
                return Ok(tokenDegeri);
            }
            catch (Exception ex)
            {

                throw;
            }
            return NotFound();
        }
    }
}
