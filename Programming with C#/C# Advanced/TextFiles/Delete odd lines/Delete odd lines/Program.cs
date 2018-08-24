using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delete_odd_lines
{
    class Program
    {
        static void Main()
        {
            List<string> str = new List<string>() { "Ivan" };
            TextLineRemover.RemoveTextLines(str, @"C:\Users\7\Desktop\result.txt", @"C:\Users\7\Desktop\res.txt");
        }
        public static class TextLineRemover
        {
            public static void RemoveTextLines(IList<string> linesToRemove, string filename, string tempFilename)
            {
                // Initial values
                int lineNumber = 0;
                int linesRemoved = 0;
                DateTime startTime = DateTime.Now;

                // Read file
                using (var sr = new StreamReader(filename))
                {
                    // Write new file
                    using (var sw = new StreamWriter(tempFilename))
                    {
                        // Read lines
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            lineNumber++;
                            // Look for text to remove
                            //if (!ContainsString(line, linesToRemove))
                            //{
                            //    // Keep lines that does not match
                            //    sw.WriteLine(line);
                            //}

                            // Look for text to remove. Removes odd lines
                            if (removeOdd(lineNumber))
                            {
                                sw.WriteLine(line);
                            }
                            else
                            {
                                // Ignore lines that DO match
                                linesRemoved++;
                                InvokeOnRemovedLine(new RemovedLineArgs { RemovedLine = line, RemovedLineNumber = lineNumber });
                            }
                        }
                    }
                }
                // Delete original file
                File.Delete(filename);

                // ... and put the temp file in its place.
                File.Move(tempFilename, filename);

                // Final calculations
                DateTime endTime = DateTime.Now;
                InvokeOnFinished(new FinishedArgs { LinesRemoved = linesRemoved, TotalLines = lineNumber, TotalTime = endTime.Subtract(startTime) });
            }

            private static bool removeOdd(int line)
            {
                if (line % 2 == 0)
                {
                    return true;
                }
                return false;
            }

            private static bool ContainsString(string line, IEnumerable<string> linesToRemove)
            {
                foreach (var lineToRemove in linesToRemove)
                {
                    if (line.Contains(lineToRemove))
                        return true;
                }
                return false;
            }

            public static event RemovedLine OnRemovedLine;
            public static event Finished OnFinished;

            public static void InvokeOnFinished(FinishedArgs args)
            {
                Finished handler = OnFinished;
                if (handler != null) handler(null, args);
            }

            public static void InvokeOnRemovedLine(RemovedLineArgs args)
            {
                RemovedLine handler = OnRemovedLine;
                if (handler != null) handler(null, args);
            }
        }

        public delegate void Finished(object sender, FinishedArgs args);

        public class FinishedArgs
        {
            public int TotalLines { get; set; }
            public int LinesRemoved { get; set; }
            public TimeSpan TotalTime { get; set; }
        }

        public delegate void RemovedLine(object sender, RemovedLineArgs args);

        public class RemovedLineArgs
        {
            public string RemovedLine { get; set; }
            public int RemovedLineNumber { get; set; }
        }
    }
}
