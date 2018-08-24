using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animals
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Myal");
        }
    }
}
