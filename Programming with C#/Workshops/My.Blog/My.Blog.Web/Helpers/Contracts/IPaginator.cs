using System.Collections.Generic;

namespace My.Blog.Web.Helpers.Contracts
{
    public interface IPaginator
    {
        T1 ApplyPagination<T1, T2>(int id, int pageSize, IEnumerable<T2> entities);
    }
}