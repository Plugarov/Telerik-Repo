namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Program
    {
        private const string AddEventsCommand = "AddEvent";
        private const string DeleteEventsCommand = "DeleteEvents";
        private const string ListEventsCommand = "ListEvents";

        static EventHolder events = new EventHolder();

        static void Main(string[] args)
        {
            while (ExecuteNextCommand()) { }
            Console.WriteLine(output);
        }

        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command.isNullOrEmpty())
            {
                return false;
            }

            switch (command[0])
            {
                case 'A':
                    {
                        AddEvent(command);
                        return true;
                    }
                case 'D':
                    {
                        DeleteEvents(command);
                        return true;
                    }
                case 'L':
                    {
                        ListEvents(command);
                        return true;
                    }
                default:
                    return false;
            }
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetCommandParameters(command, AddEventsCommand, out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        private static void DeleteEvents(string command)
        {
            string title = command.Substring(DeleteEventsCommand.Length + 1);

            events.DeleteEvents(title);
        }

        private static void ListEvents(string command)
        {
            DateTime date = GetDate(command, ListEventsCommand);
            int pipeIndex = command.IndexOf('|');
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            events.ListEvents(date, count);
        }

        private static void GetCommandParameters(
            string commandForExecution,
            string commandType,
            out DateTime dateAndTime,
            out string eventTitle,
            out string eventLocation)
        {
            var dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');
            int startIndex = firstPipeIndex + 1;

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(startIndex).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(
                    startIndex, 
                    lastPipeIndex - startIndex
                    ).Trim();

                eventLocation = commandForExecution.Substring(startIndex).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            string dateTimeAsString = command.Substring(commandType.Length + 1, 20)
            DateTime date = DateTime.Parse(dateTimeAsString);

            return date;
        }
    }
}