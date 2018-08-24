namespace Academy.Tests.Models.CourseTests
{
    using Academy.Models;
    using Academy.Models.Contracts;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void CorrectyAssignNameProperty_WhenObjectIsConstructed()
        {
            var courseUnderTest = new Course("Name", 4, new DateTime(2017, 4, 3), new DateTime(2017, 4, 3));

            Assert.AreEqual(courseUnderTest.Name, "Name");
        }

        [Test]
        public void CorrectlyInitializeOnlineStudentsCollection_WhenTheObjectIsConstructed()
        {
            var courseUnderTest = new Course("Name", 4, new DateTime(2017, 4, 3), new DateTime(2017, 4, 3));

            Assert.IsInstanceOf(typeof(IList<IStudent>), courseUnderTest.OnlineStudents);
        }
    }
}
