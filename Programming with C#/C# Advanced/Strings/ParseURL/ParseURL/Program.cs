using System;

namespace ParseURLs
{
    class Program
    {
        static void Main()
        {
            string input = @"https://github.com/gentoo/gentoo.git";
            ParseURL(input);
        }

        static void ParseURL(string url)
        {
            int startResource = url.IndexOf(".com") + 4;
            string rest = url.Substring(0, startResource);
            string[] protocolAndServer = rest.Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
            string resource = url.Substring(startResource);

            Console.WriteLine("[protocol] = {0}",protocolAndServer[0]);
            Console.WriteLine("[server] = {0}", protocolAndServer[1]);
            Console.WriteLine("[resource] = {0}", resource);

            Console.WriteLine();

            Uri myUri = new Uri("https://github.com/gentoo/gentoo.git");

            string hostpart = myUri.Host;
            string pathpart = myUri.PathAndQuery;
            string querystring = myUri.Scheme;

            Console.WriteLine("{0}\n{1}\n{2}\", hostpart, pathpart, querystring);


        }
    }
}
