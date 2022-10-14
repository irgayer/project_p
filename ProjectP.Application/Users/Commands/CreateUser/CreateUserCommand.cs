using MediatR;

namespace ProjectP.Application.Users.Commands.CreateUser;

// todo: string -> TokenResponse
public class CreateUserCommand : IRequest<string>
{
    public CreateUserCommand(string email, string userName, string password)
    {
        Email = email;
        UserName = userName;
        Password = password;
    }
    
    public string Email { get; }
    public string UserName { get; }
    public string Password { get; }
}
