using Academy.Tests.Models.Abstractions.Mock;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.Abstractions.UserTests
{
    class Username_Should
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("wq")]
        [TestCase("01234567891234567")]
        public void ThrowArgumentExceptionWhenPassedUsernameIsInvalid(string username)
        {
            var user = new UserMock("Joro");

            Assert.Throws<ArgumentException>(() => user.Username = username);
        }

        [Test]
        public void NotThrowArgumentExceptionWhenPassedUsernameIsValid()
        {
            var user = new UserMock("Joro");

            user.Username = "ValidValue";

            Assert.AreEqual(user.Username, "ValidValue");
        }
    }
}
