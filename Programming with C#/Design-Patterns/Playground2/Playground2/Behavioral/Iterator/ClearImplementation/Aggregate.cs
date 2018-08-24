using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2.Behavioral.Iterator.ClearImplementation
{
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    public abstract class Aggregate
    {
        public abstract IIterator CreateIterator();
    }
}
