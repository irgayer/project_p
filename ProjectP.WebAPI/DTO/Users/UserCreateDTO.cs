using ProjectP.Domain.Entities;

namespace ProjectP.WebAPI.DTO.Users
{
    public class UserCreateDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsMedia { get; set; } = false;
        public bool IsBussiness { get; set; } = false;

        public BiographyDTO Biography { get; set; }
    }
}
