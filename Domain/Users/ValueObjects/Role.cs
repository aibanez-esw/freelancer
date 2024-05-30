using System;

namespace Domain.Users.ValueObjects
{
    public record Role
    {
        public const string Admin = "Admin";
        public const string Client = "Client";
        public const string Freelancer = "Freelancer";

        private static string[] Allowed => new string[] { Admin, Client, Freelancer };

        protected void Validate(string value)
        {
            if (!Allowed.Any(role => role == value))
            {
                throw new Exception();
            }
        }
        private Role(string value)
        {
            Value = value;
        }

        public static Role Create(string value)
        {
            var role = new Role(value);
            role.Validate(value);
            return role;
        }

        public string Value { get; init; }
    }
}
