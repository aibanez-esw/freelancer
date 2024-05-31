using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users.ValueObjects;

namespace Domain.Tests.Users.ValueObjects
{
    public class RoleTest
    {
        [Theory]
        [MemberData(nameof(TestCorrectData))]
        public async Task GivenCreateRole_WhenCalledCorrect_ThenCreateNewRole( string value)
        {
            var role = Role.Create(value);

            Assert.Equal(value, role.Value);
        }

        [Theory]
        [MemberData(nameof(TestIncorrectData))]
        public async Task GivenCreateRole_WhenCalledIncorrect_ThenCreateNewRole(string value)
        {
            Assert.Throws<Exception>(() => Role.Create(value));

        }

        public static IEnumerable<object[]> TestCorrectData
        {
            get
            {
                yield return new object[] { "Admin" };
                yield return new object[] { "Client" };
                yield return new object[] { "Freelancer" };
            }
        }

        public static IEnumerable<object[]> TestIncorrectData
        {
            get
            {
                yield return new object[] { "Admintttt" };
            }
        }
    }
}
