using Playground2.SimpleFactory;
using System.Collections.Generic;

namespace Playground2.SimpleFactory
{
    public static class SimpleFactoryMain
    {
        public static void Run()
        {
            var requsts = new List<IHttpRequest>()
            {
                HttpRequestFactory.CreateRequest("get", "google.com",
                new string[] {"hello", "from-academy"}),
                HttpRequestFactory.CreateRequest("post  ", "academy.com",
                new string[] { "bye", "from-academy" })
            };
        }
    }
}
