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
    public class Update_Should
    {
        [Test]
        public void VerifyThatUpdateMethodIsCalledWithCorrectParameters_WhenUpdateMethodIsCalled()
        {
            // Arrange
            var postId = 1;
            var post = new Post() { Id = postId };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.Update(post);

            // Assert
            postRepoMock.Verify(m => m.Update(It.Is<Post>(x => x.Id == post.Id)), Times.Once);
        }

        [Test]
        public void VerifyThatSaveChangesMethodIsCalled_WhenUpdateMethodIsCalled()
        {
            // Arrange
            var postId = 1;
            var post = new Post() { Id = postId };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(x => x.All).Returns(new Collection<Post>() { post }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.Update(post);

            // Assert
            postRepoMock.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
