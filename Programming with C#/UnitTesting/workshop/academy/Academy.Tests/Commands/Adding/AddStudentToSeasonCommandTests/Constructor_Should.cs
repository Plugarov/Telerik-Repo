namespace Academy.Tests.Commands.Adding.AddStudentToSeasonCommandTests
{
    using Academy.Commands.Adding;
    using Academy.Commands.Contracts;
    using Academy.Core.Contracts;
    using Academy.Tests.Commands.Mock;
    using Moq;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedFactoryIsNull()
        {
            var engineMock = new Mock<IEngine>();

            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenPassedEngineIsNull()
        {
            var factoryMock = new Mock<IAcademyFactory>();

            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(factoryMock.Object, null));
        }

        [Test]
        public void AssignCorrectValueToEngine_WhenPassedDependenciesAreNotNull()
        {
            // Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();

            // Act 
            var command = new AddStudentToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            // Assert
            Assert.AreSame(engineMock.Object, command.Engine);
        }

        [Test]
        public void AssignCorrectValueToFactory_WhenPassedDependenciesAreNotNull()
        {
            // Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();

            // Act 
            var command = new AddStudentToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            // Assert
            Assert.AreSame(factoryMock.Object, command.AcademyFactory);
        }
    }
}
