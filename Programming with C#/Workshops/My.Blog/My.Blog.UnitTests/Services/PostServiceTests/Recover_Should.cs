using System.Collections.ObjectModel;
using System.Linq;

using Moq;
using NUnit.Framework;

using My.Blog.Data.Models;
using My.Blog.Data.Contracts;
using My.Blog.Services;
using My.Blog.Services.Contracts;

namespace my.blog.unittests.services.postservicetests
{
    [TestFixture]
    public class Recover_Should
    {
        [Test]
        public void VerifyThatRecoverMethodIsCalled_WhenRecoverIsCalled()
        {
            // Arrange
            var postid = 1;
            var post = new Post() { Id = postid };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(x => x.AllAndDeleted).Returns(new Collection<Post>() { post }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.Recover(postid);

            // Assert
            postRepoMock.Verify(m => m.Recover(post), Times.Once);
        }

        [Test]
        public void VerifyThatSaveChangesMethodIsCalled_WhenDeleteIsCalled()
        {
            // Arrange
            var postid = 1;
            var post = new Post() { Id = postid };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(x => x.All).Returns(new Collection<Post>() { post }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.Recover(postid);

            // Assert
            postRepoMock.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
