using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Common;
using My.Blog.Web.Helpers.Contracts;
using My.Blog.Web.Models.Comments;

namespace My.Blog.Web.Areas.Administration.Controllers
{
    public class CommentsController : AdminController
    {
        private readonly IPostCommentService postCommentService;
        private readonly IPostService postService;
        private readonly IPaginator paginator;

        public CommentsController(IPostCommentService postCommentService, IPostService postService, IMappingService mappingService, IPaginator paginator)
            : base(mappingService)
        {
            this.postCommentService = postCommentService ?? throw new ArgumentNullException();
            this.postService = postService ?? throw new ArgumentNullException();
            this.paginator = paginator ?? throw new ArgumentNullException();
        }

        public ActionResult All(int id = GlobalConstraints.AdminCommentsPaginationStartPage, int pageSize = GlobalConstraints.AdminCommentsPaginationPageSize)
        {
            var comments = this.postCommentService.GetAllAndDeleted().ToList();
            var postCommentModel = mappingService.Map<IList<PostComment>, ICollection<PostCommentAnnotationViewModel>>(comments);

            var postCommentsViewModel = paginator.ApplyPagination<PostCommentPaginationModel, PostCommentAnnotationViewModel>(id, pageSize, postCommentModel);

            return this.View(postCommentsViewModel);
        }

        public ActionResult AllByPostId(int id)
        {
            var comments = this.postCommentService
                .GetAllAndDeleted()
                .Where(c => c.PostId == id)
                .OrderByDescending(p => p.CreatedOn)
                .ToList();

            var commentsModel = mappingService.Map<IList<PostComment>, ICollection<PostCommentAnnotationViewModel>>(comments);

            var postCommentsViewModel = new PostCommentViewModel()
            {
                Comments = commentsModel
            };

            return this.View(postCommentsViewModel);
        }

        public ActionResult Edit(int id)
        {
            var comment = this.postCommentService.GetById(id);
            var postCommentsViewModel = this.mappingService.Map<PostCommentAnnotationViewModel>(comment);

            return this.View(postCommentsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Content, CreatedOn, IsDeleted, PostId")] PostCommentAnnotationViewModel postComment)
        {
            if (ModelState.IsValid)
            {
                var comment = this.mappingService.Map<PostComment>(postComment);

                this.postCommentService.Update(comment);

                return this.RedirectToAction("AllByPostId", "Comments", new { id = postComment.PostId });
            }

            return this.View();
        }

        //todo validate token?
        public ActionResult Delete(int id, int postId = 0)
        {
            this.postCommentService.Delete(id);

            if (postId != 0)
            {
                return this.RedirectToAction("AllByPostId", "Comments", new { Id = postId });
            }

            return this.RedirectToAction("All", "Comments");
        }

        public ActionResult Recover(int id, int postId = 0)
        {
            this.postCommentService.Recover(id);

            if (postId != 0)
            {
                return this.RedirectToAction("AllByPostId", "Comments", new { Id = postId });
            }

            return this.RedirectToAction("All", "Comments");
        }
    }
}