using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2.Structural.Flyweight
{
    using System;

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class CharacterB : Character
    {
        public CharacterB()
        {
            this.Symbol = 'B';
            this.Height = 100;
            this.Width = 140;
            this.Ascent = 72;
            this.Descent = 0;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine("{0} (point size {1})", this.Symbol, pointSize);
        }
    }
}
