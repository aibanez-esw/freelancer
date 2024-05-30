using Application.Abstractions;

namespace Application.Users.Dto
{
    public record CreateUserResponseDto : IResponse
    {
        public string Message { get; } = "User created";
    }
}
