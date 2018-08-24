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
    public class GetById_Should
    {
        [Test]
        public void ReturnNull_WhenModelWithPassedIdDoesNotExist()
        {
            // Arrange
            int existingId = 1;
            int searchId = 5;

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(m => m.AllAndDeleted).Returns(new Collection<Post>() { new Post() { Id = existingId } }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            var sut = postService.GetById(searchId);

            // Assert   
            Assert.IsNull(sut);
        }

        [Test]
        public void ReturnModel_WhenModelWithPassedIdExists()
        {
            // Arrange
            int postId = 5;

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(m => m.AllAndDeleted).Returns(new Collection<Post>() { new Post() { Id = postId } }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            var sut = postService.GetById(postId);

            // Assert   
            Assert.IsInstanceOf<Post>(sut);
        }
    }
}
