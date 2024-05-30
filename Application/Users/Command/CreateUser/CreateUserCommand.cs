using Application.Users.Dto;

namespace Application.Users.Command.CreateUser
{
    public record CreateUserCommand(string Username, string Password, string Email, string Role, ContactInformationDto? ContactInformation);
}
