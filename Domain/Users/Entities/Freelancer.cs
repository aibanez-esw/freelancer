using Domain.Users.ValueObjects;

namespace Domain.Users.Entities
{
    public class Freelancer(string username, string password, string email, Role role) : User(username, password, email, role)
    {
        public string? Expertise { get; private set; }
        public ContactInformation? ContactInformation { get; private set; }

        private Freelancer(string username, string password, string email, Role role, string expertise, ContactInformation contactInformation) :
            this(username, password, email, role)
        {
            Expertise = expertise;
            ContactInformation = contactInformation;
        }

        public static Freelancer Create(string username, string password, string email, Role role, string expertise, ContactInformation contactInformation)
        {
            return new Freelancer(username, password, email, role, expertise, contactInformation);
        }
    }
}
