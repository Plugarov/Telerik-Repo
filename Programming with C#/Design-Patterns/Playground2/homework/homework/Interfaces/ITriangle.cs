using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Interfaces
{
    public interface ITriangle : IShape
    {
        int sideA { get; set; }
        int sideB { get; set; }
        int sideC { get; set; }
    }
}
