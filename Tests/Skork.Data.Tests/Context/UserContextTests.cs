using NUnit.Framework;
using Skork.Data.Context;

namespace Skork.Data.Tests.Context
{
    [TestFixture()]
    [Author("Reapism")]
    [Description("Tests for the UserContext class.")]
    public class UserContextTests
    {
        private UserContext _userContext;

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void ShouldAddUserGivenNonNullData()
        {
            Assert.Fail();
        }

        [Test]
        public void ShouldNotAddUserGivenNullData()
        {
            Assert.Fail();
        }

        [Test]
        public void ShouldNotAddUserGivenDuplicateEmailData()
        {
            Assert.Fail();
        }

        [Test]
        public void ShouldNotAddUserGivenDuplicateNewAndOldPassword()
        {
            Assert.Fail();
        }
    }
}
