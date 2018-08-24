namespace My.Blog.Web.Helpers.Contracts
{
    public interface IBlogUrlGenerator
    {
        string GenerateUrl(int id, string title);
    }
}