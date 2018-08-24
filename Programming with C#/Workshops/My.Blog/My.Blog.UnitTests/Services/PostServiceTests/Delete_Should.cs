using System.Collections.ObjectModel;
using System.Linq;

using Moq;
using NUnit.Framework;

using My.Blog.Data.Contracts;
using My.Blog.Services;
using My.Blog.Services.Contracts;
using My.Blog.Data.Models;

namespace my.blog.unittests.services.postservicetests
{
    [TestFixture]
    public class Delete_Should
    {
        [Test]
        public void VerifyThatDeleteMethodIsCalled_WhenDeleteIsCalled()
        {
            // Arrange
            var postid = 1;
            var post = new Post() { Id = postid };

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            postRepoMock.Setup(x => x.All).Returns(new Collection<Post>() { post }.AsQueryable());
            var userServiceMock = new Mock<IUserService>();

            var postservice = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postservice.Delete(postid);

            // Assert
            postRepoMock.Verify(m => m.Delete(post), Times.Once);
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

            var postservice = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postservice.Delete(postid);

            // Assert
            postRepoMock.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
