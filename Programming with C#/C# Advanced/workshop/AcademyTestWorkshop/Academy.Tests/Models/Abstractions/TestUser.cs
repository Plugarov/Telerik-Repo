using System;
using Academy.Models;
using Academy.Models.Abstractions;
using NUnit.Framework;

namespace Academy.Tests.Models.Abstractions
{
    [TestFixture]
    public class TestUser
    {
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Constructor_ShouldCorrectlyAssignPassedValuesOrThrowArgExWhenInvalid(string name)
        {
            IUser userInstance = new TestingUser("Joro");

            Assert.Throws<ArgumentException>(() => new TestingUser(name));

            Assert.AreEqual(userInstance.Username, "Joro");
        }

        public class TestingUser : User, IUser
        {
            public TestingUser(string username)
                : base(username)
            {
            }
        }


    }
}

