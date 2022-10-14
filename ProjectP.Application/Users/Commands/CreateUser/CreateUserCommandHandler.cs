using MediatR;

using ProjectP.Application.Core.Abstractions.Authentication;
using ProjectP.Application.Core.Abstractions.Cryptography;
using ProjectP.Application.Core.Abstractions.Data;
using ProjectP.Domain.Repositories;

namespace ProjectP.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;

    public CreateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IUnitOfWork unitOfWork, IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
    }

    public Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
