using Academy.Models;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.SeasonTests
{
    [TestFixture]
    class ListUsers_Should
    {
        [Test]
        public void IterateOverTheCollection_WhenTheCollectionStudentsIsNotEmpty_Moq()
        {
            // Arrange
            var classUnderTest = new Season(2017,2017, Academy.Models.Enums.Initiative.CoderDojo);
            var mockStudent = new Mock<IStudent>();
            mockStudent.Setup(x => x.ToString()).Returns("");
            classUnderTest.Students.Add(mockStudent.Object);

            // Act
            classUnderTest.ListUsers();

            // Assert
            mockStudent.Verify(x => x.ToString(), Times.Exactly(1));
        }

        [Test]
        public void IterateOverTheCollection_WhenTheCollectionTrainersIsNotEmpty_Moq()
        {
            // Arrange
            var classUnderTest = new Season(2017, 2017, Academy.Models.Enums.Initiative.CoderDojo);
            var mockTrainer = new Mock<ITrainer>();
            mockTrainer.Setup(x => x.ToString()).Returns("");
            classUnderTest.Trainers.Add(mockTrainer.Object);

            // Act
            classUnderTest.ListUsers();

            // Assert
            mockTrainer.Verify(x => x.ToString(), Times.Exactly(1));
        }

        [Test]
        public void IterateOverTheCollection_WhenTheCollectionsAreEmpty_Moq()
        {
            // Arrange
            var classUnderTest = new Season(2017, 2017, Academy.Models.Enums.Initiative.CoderDojo);
            var mockTrainer = new Mock<ITrainer>();

            // Act
            string result = classUnderTest.ListUsers();

            // Assert
            Assert.Contains(result, new List<string>() { "There are no users in this season!" });
        }
    }
}
