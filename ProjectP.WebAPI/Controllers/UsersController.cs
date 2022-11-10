using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

using ProjectP.Domain.Entities;
using ProjectP.Domain.Repositories;
using ProjectP.WebAPI.DTO.Users;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProjectP.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    IConfiguration configuration;
    IUserRepository userRepository;
    
    public UsersController(IUserRepository userRepository, IConfiguration configuration)
    {
        this.userRepository = userRepository;
        this.configuration = configuration;
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("register")]
    public IActionResult RegisterUserAsync(UserCreateDTO dto)
    {
        var user = new User()
        {
            Email = dto.Email,
            Password = dto.Password,
            UserName = dto.UserName,
        };

        userRepository.Insert(user);

        return Ok();
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> LoginUserAsync(UserLoginDTO dto)
    {
        var user = await AuthenticateAsync(dto);
        if (user == null)
        {
            return Unauthorized();
        }

        var token = Generate(user);
        return Ok(token);
    }

    private string Generate(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        };

        var token = new JwtSecurityToken(
            configuration["Jwt:Issuer"],
            configuration["Jwt:Audience"],
            claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private async Task<User?> AuthenticateAsync(UserLoginDTO dto)
    {
        var user = await userRepository.GetUserByEmail(dto.Email);
        if (user == null)
            return null;
        if (user?.Password != dto.Password)
            return null;

        return user;
    }
}
