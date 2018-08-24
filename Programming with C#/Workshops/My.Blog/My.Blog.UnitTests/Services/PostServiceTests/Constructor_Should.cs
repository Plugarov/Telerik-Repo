using System;

using Moq;
using NUnit.Framework;

using My.Blog.Services;
using My.Blog.Services.Contracts;
using My.Blog.Data.Models;
using My.Blog.Data.Contracts;

namespace My.Blog.UnitTests.Services.PostServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ReturnsAnInstance_WhenBothParametersAreNotNull()
        {
            // Arrange
            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();

            // Act
            var sut = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Assert
            Assert.IsNotNull(sut);
        }

        [Test]
        public void ThrowException_WhenUserRepoIsNull()
        {
            // Arrange 
            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PostService(postRepoMock.Object, null));
        }

        [Test]
        public void ThrowException_WhenPostRepoIsNull()
        {
            // Arrange 
            var userServiceMock = new Mock<IUserService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PostService(null, userServiceMock.Object));
        }
    }
}
