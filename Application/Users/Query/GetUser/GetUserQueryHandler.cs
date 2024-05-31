using Domain.Users.Entities;
using Domain.Users.Repository;

namespace Application.Users.Query.GetUser
{
    public class GetUserQueryHandler
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetAsync(request.uuid);
            
            if (user == null) {
                throw new Exception("User not found");
            }

            return user;
            
        }
    }
}
