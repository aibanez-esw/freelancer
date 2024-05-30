namespace Domain.Users.ValueObjects
{
    public record ContactInformation
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        private ContactInformation(string email, string phone, string address)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }

        public static ContactInformation Create(string email, string phone, string address)
        {
            return new ContactInformation(email, phone, address);
        }
    }
}
