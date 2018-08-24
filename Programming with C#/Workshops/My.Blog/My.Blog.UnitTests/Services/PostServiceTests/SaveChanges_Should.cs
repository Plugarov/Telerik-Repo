using Moq;
using NUnit.Framework;

using My.Blog.Data.Contracts;
using My.Blog.Data.Models;
using My.Blog.Services;
using My.Blog.Services.Contracts;

namespace My.Blog.UnitTests.Services.PostServiceTests
{
    [TestFixture]
    public class SaveChanges_Should
    {
        [Test]
        public void VerifyThatSaveChangesMethodIsCalled_WhenIsCalledPassed()
        {
            // Arrange
            var postId = 1;
            var post = new Post() { Id = postId };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.SaveChanges();

            // Assert
            postRepoMock.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
