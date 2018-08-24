using Moq;
using NUnit.Framework;

using My.Blog.Data.Contracts;
using My.Blog.Data.Models;
using My.Blog.Services;
using My.Blog.Services.Contracts;

namespace My.Blog.UnitTests.Services.PostServiceTests
{
    [TestFixture]
    public class Attach_Should
    {
        [Test]
        public void VerifyThatAttachMethodIsCalled_WhenIdIsPassed()
        {
            // Arrange
            var postId = 1;
            var post = new Post() { Id = postId };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.Attach(post);

            // Assert
            postRepoMock.Verify(m => m.Attach(It.Is<Post>(x => x.Id == post.Id)), Times.Once);
        }
    }
}
