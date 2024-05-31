using Application.Users.Query.GetUser;
using Domain.Users.Entities;
using Domain.Users.Repository;
using Domain.Users.ValueObjects;
using Moq;

namespace Application.Tests.Users.Query.GetUser
{
    public class GetUserQueryHandlerTest
    {
        [Fact]
        public async Task GivenGetUserQueryHandler_WhenGetUserQueryIsValid_ThenReturnUser()
        {
            // Arrange
            var userRepository = new Mock<IUserRepository>();
            var user = Freelancer.Create(
                "username",
                "password",
                "email",
                Role.Create(Role.Freelancer),
                "expertise",
                ContactInformation.Create("email", "phone", "address")
            );
            userRepository.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(user);

            var getUserQueryHandler = new GetUserQueryHandler(userRepository.Object);
            var getUserQuery = new GetUserQuery(Guid.NewGuid());

            // Act
            var result = await getUserQueryHandler.Handle(getUserQuery, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user, result);
            userRepository.Verify(x => x.GetAsync(It.IsAny<Guid>()), Times.Once());
        }

        [Fact]
        public async Task GivenGetUserQueryHandler_WhenGetUserQueryIsNotValid_ThenThrowException()
        {
            // Arrange
            var userRepository = new Mock<IUserRepository>();
            userRepository.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync((User?) null);

            var getUserQueryHandler = new GetUserQueryHandler(userRepository.Object);
            var getUserQuery = new GetUserQuery(Guid.NewGuid());

            // Act
            // Assert
            await Assert.ThrowsAsync<Exception>(() => getUserQueryHandler.Handle(getUserQuery, CancellationToken.None));
            userRepository.Verify(x => x.GetAsync(It.IsAny<Guid>()), Times.Once());
        }
    }
}
