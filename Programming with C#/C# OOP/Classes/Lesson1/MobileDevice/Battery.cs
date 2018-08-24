using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Battery
    {
        private const string defaultModel = "unset";
        private const short defaultIdleHrs = 0;
        private const short defaultTalkHrs = 0;

        private string model;
        private short idleHrs;
        private short talkHrs;

        public Battery() : this(defaultModel, defaultIdleHrs, defaultTalkHrs)
        {

        }

        public Battery(string model, short idleHrs, short talkHrs)
        {
            this.model = model;
            this.idleHrs = idleHrs;
            this.talkHrs = talkHrs;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Battery Information: ");
            result.Append(string.Format("\n Model: {0}\n Idle Hours: {1}\n Talk Hours: {2}\n",
                this.model, this.idleHrs, this.talkHrs));
            return result.ToString();
        }
    }
}
