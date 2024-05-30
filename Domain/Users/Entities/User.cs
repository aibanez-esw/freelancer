using Domain.Abstraction;
using Domain.Users.ValueObjects;

namespace Domain.Users.Entities
{
    public abstract class User: Entity
    {
        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Email { get; private set; }

        public Role Role { get; private set; }

        protected User(string username, string password, string email, Role role)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
        }
    }
}
