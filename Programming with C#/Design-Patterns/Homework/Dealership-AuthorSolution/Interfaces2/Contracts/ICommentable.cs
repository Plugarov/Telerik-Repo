using System.Collections.Generic;

namespace Interfaces.Contracts
{
    public interface ICommentable
    {
        IList<IComment> Comments { get; }
    }
}
