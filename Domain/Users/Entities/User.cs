using Domain.Abstraction;

namespace Domain.Users.Entities
{
    public abstract class User: Entity
    {
        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Email { get; private set; }

        private User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
