using ProjectP.Domain.Entities;

using System.ComponentModel.DataAnnotations;

namespace ProjectP.WebAPI.DTO.Users
{
    public class UserCreateDTO
    {
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool? IsMedia { get; set; } = false;
        public bool? IsBussiness { get; set; } = false;

        public BiographyDTO? Biography { get; set; }
    }
}
