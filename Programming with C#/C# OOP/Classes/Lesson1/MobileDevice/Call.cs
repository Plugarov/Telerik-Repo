using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Call
    {
        private string number;
        private double duration;

        public Call(string number, int duration)
        {
            this.number = number;
            this.duration = duration;
        }

        public double GetCallDuration()
        {
            return duration;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Call: ");
            result.Append(number);
            result.AppendLine();
            result.Append("Duration: ");
            result.Append(duration);
            result.AppendLine();
            return result.ToString();
        }
    }
}
