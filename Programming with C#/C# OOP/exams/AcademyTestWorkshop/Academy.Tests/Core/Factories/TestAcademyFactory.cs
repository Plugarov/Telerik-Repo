using System;
using Academy.Core.Factories;
using NUnit.Framework;

namespace Academy.Tests.Core.Factories
{
    [TestFixture]
    public class TestAdacemyFactory
    {
        [Test]
        [TestCase("video", null, null)]
        [TestCase("video", "video", null)]
        [TestCase("video", null, "video")]
        [TestCase(null, null, null)]
        public void CreateLectureResource_ShouldReturnCorrectInstancesAndThrowArgExWhenInvalidData(
            string type, string name, string url)
        {
            var a = AcademyFactory.Instance;
            a.CreateLectureResource("video", "Some", "links");

            Assert.Throws<ArgumentException>(() => a.CreateLectureResource(type, name, url));
        }
    }
}

