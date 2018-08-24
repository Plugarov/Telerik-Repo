using System.Collections.Generic;

namespace Interfaces.Engine
{
    public interface IRequestParser
    {
        List<string> Parameters { get; }

        string Name { get; }
    }
}