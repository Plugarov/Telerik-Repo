using NUnit.Framework;
using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using System;

namespace Academy.Tests.Models
{
    [TestFixture]
    public class TestCourse
    {
        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("01234567890123456789012345678901234567890123456789")]
        public void Name_ShouldThrowArgExWhenPassedValueIfLess3More45NullWhitespace(string str)
        {
            Assert.Throws<ArgumentException>(
                () => new Course(str, 5, DateTime.Now, DateTime.Now));
        }

        [Test]
        [TestCase(0)]
        [TestCase(8)]
        public void LecturesPerWeek_ShouldThrowArgExIfPassedValueIsLess1More7(int str)
        {
            ICourse course = new Course("string", 5, DateTime.Now, DateTime.Now);

            Assert.Throws<ArgumentException>(() => course.LecturesPerWeek = str);
        }

        [Test]
        [TestCase(null)]
        public void StartingDate_ShouldThrowArgExIfPassedValueIsNull(DateTime date)
        {
            ICourse course = new Course("string", 5, DateTime.Now, DateTime.Now);

            Assert.Throws<ArgumentNullException>(() => course.StartingDate = date);
        }

        [Test]
        [TestCase(null)]
        public void EndingDate_ShouldThrowArgExIfPassedValueIsNull(DateTime date)
        {
            ICourse course = new Course("string", 5, DateTime.Now, DateTime.Now);

            Assert.Throws<ArgumentNullException>(() => course.StartingDate = date);
        }

        [Test]
        public void Lectures_ShouldReturnPassedDataOrMsgNoLecturesInCourse()
        {
            ICourse course = new Course("string", 5, DateTime.Now, DateTime.Now);

            Assert.IsEmpty(course.Lectures);
        }

    }
}
