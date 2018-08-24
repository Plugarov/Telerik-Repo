namespace Events
{
    class EventHolder
    {
        MultiDictionary<string, Event> orderedByTitle = new MultiDictionary<string, Event>(true);
        OrderedBag<Event> orderedByDate = new OrderedBag<Event>();

        Messages messages = new Messages();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);

            orderedByTitle.Add(title.ToLower(), newEvent);
            orderedByDate.Add(newEvent);
            messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in orderedByTitle[title])
            {
                removed++;
                orderedByTitle.Remove(eventToRemove);
            }

            orderedByTitle.Remove(title);

            messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int numOfEventsToShow)
        {
            string title = string.Empty;
            string location = string.Empty;

            OrderedBag<Event>.View eventsToShow =
                orderedByTitle.RangeFrom(new Event(date, title, location), true);

            int showedEvents = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showedEvents == numOfEventsToShow)
                {
                    break;
                }

                messages.PrintEvent(eventToShow);

                showedEvents++;
            }

            if (counter == 0)
            {
                messages.NoEventsFound();
            }
        }
    }
}