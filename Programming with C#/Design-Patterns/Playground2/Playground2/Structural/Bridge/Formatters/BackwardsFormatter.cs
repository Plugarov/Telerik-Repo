using System.Linq;

namespace Playground2.Structural.Bridge.Formatters
{
    internal class BackwardsFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, new string(value.Reverse().ToArray()));
        }
    }
}
