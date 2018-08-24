namespace My.Blog.Web.Common
{
    public class GlobalConstraints
    {
        public const string AdministratorRoleName = "Admin";
        public const string PostImageFolderPath = "~/Img/PostsImages/";

        public const int AdminCommentsPaginationStartPage = 1;
        public const int AdminCommentsPaginationPageSize = 10;

        public const int AdminPostsPaginationStartPage = 1;
        public const int AdminPostsPaginationPageSize = 10;

        public const int AdminTagsPaginationStartPage = 1;
        public const int AdminTagsPaginationPageSize = 10;

        public const int HomePaginationStartPage = 1;
        public const int HomePaginationPageSize = 5;
    }
}
