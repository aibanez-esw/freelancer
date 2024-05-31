using Application.Users.Command.CreateUser;
using Application.Users.Dto;
using Domain.Users.Entities;
using Domain.Users.Repository;
using Domain.Users.ValueObjects;
using Moq;

namespace Application.Tests.Users.Command.CreateUser
{
    public class CreateUserCommandHandlerTest
    {
        [Theory]
        [MemberData(nameof(TestCorrectData))]
        public async Task GivenCreateUserCommandHandler_WhenHandleCalled_ThenCreateNewUser(CreateUserCommand command)
        {
            // Arrange
            var UserRepositoryMock = new Mock<IUserRepository>();
            UserRepositoryMock.Setup(x => x.AddAsync(It.IsAny<User>()));

            var handler = new CreateUserCommandHandler(UserRepositoryMock.Object);

            // Act
            await handler.Handle(command, CancellationToken.None);

            //Assert
            UserRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once());
        }

        public static IEnumerable<object[]> TestCorrectData
        {
            get
            {
                yield return new object[] {
                    new CreateUserCommand(
                        "username",
                        "password",
                        "email",
                        Role.Freelancer,
                        "expertise",
                        new ContactInformationDto(
                            "email",
                            "phone",
                            "address")
                    )
                };
            }
        }
    }
}
