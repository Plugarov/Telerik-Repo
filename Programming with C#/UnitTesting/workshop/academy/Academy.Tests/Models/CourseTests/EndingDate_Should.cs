using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    class EndingDate_Should
    {
        [Test]
        public void ReturnTheCorrectValue_WhenCalledWithGetMethod()
        {
            var courseUnderTest = new Course("Name", 4, new DateTime(2017, 4, 3), new DateTime(2017, 4, 3));

            Assert.AreEqual(courseUnderTest.EndingDate, new DateTime(2017, 4, 3));
        }
    }
}
