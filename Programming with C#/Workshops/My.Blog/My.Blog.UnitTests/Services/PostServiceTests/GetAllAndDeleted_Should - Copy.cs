using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Moq;
using NUnit.Framework;

using My.Blog.Data.Contracts;
using My.Blog.Data.Models;
using My.Blog.Services;
using My.Blog.Services.Contracts;

namespace My.Blog.UnitTests.Services.PostServiceTests
{
    [TestFixture]
    public class GetAllAndDeleted_Should
    {
        [Test]
        public void ReturnEmptyCollection_WhenItemsDoesNotPresentInCollection()
        {
            // Arrange
            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(m => m.All).Returns(new Collection<Post>() { }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            var sut = postService.GetAllAndDeleted();

            // Assert
            Assert.IsEmpty(sut);
        }

        [Test]
        public void ReturnsPosts_WhenItemsPresentInCollection()
        {
            // Arrange
            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(m => m.All).Returns(new Collection<Post>() { new Post() }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            var sut = postService.GetAllAndDeleted();

            //Assert
            Assert.IsInstanceOf<IEnumerable<Post>>(sut);
        }
    }
}