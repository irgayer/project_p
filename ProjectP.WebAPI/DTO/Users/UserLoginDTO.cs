using System.ComponentModel.DataAnnotations;

namespace ProjectP.WebAPI.DTO.Users
{
    public class UserLoginDTO
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
