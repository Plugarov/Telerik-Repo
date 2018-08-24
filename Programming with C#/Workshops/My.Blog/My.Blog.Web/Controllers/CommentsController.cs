using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Models.Comments;

namespace My.Blog.Web.Controllers
{
    public class CommentsController : BaseController
    {
        private readonly IPostCommentService postCommentService;
        private readonly IPostService postService;

        public CommentsController(IPostCommentService postCommentService, IPostService postService, IMappingService mappingService)
            : base(mappingService)
        {
            this.postCommentService = postCommentService ?? throw new ArgumentNullException();
            this.postService = postService ?? throw new ArgumentNullException();
        }

        public ActionResult All(int id)
        {
            this.Request.IsAjaxRequest();

            var comments = this.postCommentService
                .GetAll()
                .Where(c => c.PostId == id)
                .ToList();

            var postCommentsModel = mappingService.Map<IList<PostComment>, ICollection<PostCommentAnnotationViewModel>>(comments);

            var postCommentViewModel = new PostCommentViewModel()
            {
                Comments = postCommentsModel
            };

            return this.PartialView(postCommentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNew([Bind(Include = "Content")]PostCommentAnnotationViewModel comment, int PostId)
        {
            if (ModelState.IsValid)
            {
                this.postCommentService.AddNew(comment.Content, PostId);

                return this.RedirectToAction("Index", "Home", null);
            }

            return this.View();
        }
    }
}