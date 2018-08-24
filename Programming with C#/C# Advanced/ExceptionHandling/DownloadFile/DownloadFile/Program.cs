using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\7\Desktop\ninja.png";
            string address = @"http://s1.iconbird.com/ico/1012/LittlearIcons/w256h2561350591072jpg.png";

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(address, path);
                }
                catch (ArgumentException)
                {
                    Console.Error.WriteLine("\n-> Error: You have entered an empty URL!");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("\n-> Error: You have entered an invalid URL!");
                }
                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("\n-> Error: This method does not support simultaneous downloads!");
                }
                finally
                {
                    Console.WriteLine("\nGoodbye!\n");
                }

            }
        }
    }
}
