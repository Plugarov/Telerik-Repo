using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Display
    {
        private const short defaultSize = 0;
        private const uint defaultColours = 0;
        private short size;
        private uint colors;

        public Display() : this(defaultSize, defaultColours)
        {

        }

        public Display(short size, uint colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Display Information: ");
            result.Append(string.Format("\n Size: {0}\n Colors: {1}\n",
                this.size, this.colors));
            return result.ToString();
        }
    }
}
