using System.Collections.Generic;
using System.Linq;

using Moq;
using NUnit.Framework;

using My.Blog.Data.Contracts;
using My.Blog.Services;
using My.Blog.Data.Models;
using My.Blog.Services.Contracts;

namespace My.Blog.UnitTests.Services.PostServiceTests
{
    [TestFixture]
    public class AddNew_Should
    {
        [Test]
        public void VerifyThatAddMethodIsCalled_WhenCorrectParameterArePassed()
        {
            // Arrange
            int tagid = 1;
            string tagName = "C#";
            var tag = new Tag() { Id = tagid, Name = tagName };

            string userUsername = "Ivan";
            string postTitle = "title";
            string postContent = "content";
            string filename = "filename";
            IList<Tag> tags = new List<Tag>() { tag };
            ApplicationUser appUser = new ApplicationUser();
            appUser.UserName = userUsername;

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();
            userServiceMock.Setup(u => u.Get()).Returns(appUser);

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            var post = new Post()
            {
                Title = postTitle,
                Content = postContent,
                PostImageName = filename,
                User = appUser,
                Tags = tags
            };

            // Act
            postService.AddNew(tags, postTitle, postContent, filename);

            // Assert
            postRepoMock.Verify(
                m => m.Add(
                    It.Is<Post>(
                        x => x.Content == postContent &&
                        x.Title == postTitle &&
                        x.PostImageName == filename &&
                        x.User == appUser &&
                        x.Tags.First().Name == tags.First().Name)),
                Times.Once);
        }

        [Test]
        public void VerifyThatAttachMethodIsCalled_WhenCorrectParameterArePassed()
        {
            // Arrange
            int tagid = 1;
            string tagName = "C#";
            string userUsername = "Ivan";

            IList<Tag> tags = new List<Tag>() { new Tag() { Id = tagid, Name = tagName } };
            string postTitle = "title";
            string postContent = "content";
            string filename = "filename";
            ApplicationUser appUser = new ApplicationUser();
            appUser.UserName = userUsername;

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();
            userServiceMock.Setup(u => u.Get()).Returns(appUser);

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            var post = new Post()
            {
                Title = postTitle,
                Content = postContent,
                PostImageName = filename,
                User = appUser,
                Tags = tags
            };

            // Act
            postService.AddNew(tags, postTitle, postContent, filename);

            // Assert
            postRepoMock.Verify(
                m => m.Attach(
                    It.Is<Post>(
                        x => x.Content == postContent &&
                        x.Title == postTitle &&
                        x.PostImageName == filename &&
                        x.User.UserName == appUser.UserName &&
                        x.Tags.First().Name == tags.First().Name)),
                Times.Once);
        }

        [Test]
        public void VerifyThatSaveChangesMethodIsCalled_WhenCorrectParameterArePassed()
        {
            // Arrange
            int tagid = 1;
            string tagName = "C#";

            IList<Tag> tags = new List<Tag>() { new Tag() { Id = tagid, Name = tagName } };
            string postTitle = "title";
            string postContent = "content";
            string filename = "filename";

            var postRepoMock = new Mock<IEfDeletableEntityRepository<Post>>();
            var userServiceMock = new Mock<IUserService>();

            var postService = new PostService(postRepoMock.Object, userServiceMock.Object);

            // Act
            postService.AddNew(tags, postTitle, postContent, filename);

            // Assert
            postRepoMock.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
