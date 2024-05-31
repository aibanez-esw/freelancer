using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users.ValueObjects;
    
namespace Domain.Tests.Users.ValueObjects
{
    public class ContactInformationTest
    {
        [Theory]
        [MemberData(nameof(TestCorrectData))]
        public async Task GivenCreateContactInformation_WhenCalledCorrect_ThenCreateNewContactInformation(string email, string phone, string address)
        {
            var contactInformation = ContactInformation.Create(email, phone, address);

            Assert.Equal(email, contactInformation.Email);
            Assert.Equal(phone, contactInformation.Phone);
            Assert.Equal(address, contactInformation.Address);
        }


        public static IEnumerable<object[]> TestCorrectData
        {
            get
            {
                yield return new object[] { "email", "phone", "address" };
            }
        }



    }
}
