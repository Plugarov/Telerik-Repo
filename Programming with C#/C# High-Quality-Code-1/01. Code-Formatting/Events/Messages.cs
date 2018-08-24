namespace Events
{
    using System;
    using System.Linq;
    using System.Text;

    static class Messages
    {
        private const string EventDeletedMessage = "{0} events deleted\n";
        private const string EventAddedMessage = "Event added\n";
        private const string NoEventsFoundMessage= "No events found\n";

        static StringBuilder output = new StringBuilder();

        public static void EventAdded()
        {
            output.Append(EventAddedMessage);
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat(EventDeletedMessage, x);
            }
        }

        public static void NoEventsFound()
        {
            output.Append(NoEventsFoundMessage);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }
}