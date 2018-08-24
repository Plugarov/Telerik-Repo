using Academy.Tests.Models.Abstractions.Mock;
using NUnit.Framework;

namespace Academy.Tests.Models.Abstractions.UserTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void CorrectlyAssignCourseName_WhenTheObjectIsConstructed()
        {
            var user = new UserMock("Joro");

            Assert.AreEqual(user.Username, "Joro");
        }
    }
}
