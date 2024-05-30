using Application.Users.Dto;
using Domain.Users.Entities;
using Domain.Users.ValueObjects;

namespace Application.Users.Command.CreateUser
{
    public class CreateUserCommandHandler
    {
        public async Task<CreateUserResponseDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user;
            if (request.Role == "Freelancer")
            {
                user = Freelancer.Create(
                    request.Username,
                    request.Password,
                    request.Email,
                    Role.Create(Role.Freelancer),
                    request.Expertise!,
                    ContactInformation.Create(request.ContactInformation?.Email!, request.ContactInformation?.Phone!, request.ContactInformation?.Address!)
                );
            }
            else
            {
                throw new Exception("User role is not valid");
            }
            
            return await Task.FromResult(new CreateUserResponseDto());
            
        }
    }
}
