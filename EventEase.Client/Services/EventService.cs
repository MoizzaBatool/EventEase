using EventEase.Client.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Client.Services
{
    public class EventService
    {
        private readonly List<Event> events = new List<Event>();
        private readonly List<Attendee> attendees = new List<Attendee>();

        public List<Event> GetEvents() => events;

        public void AddEvent(Event e)
        {
            if (e != null)
            {
                events.Add(e);
            }
        }

        public void RegisterAttendee(Attendee a)
        {
            if (a != null && events.Any(ev => ev.Id == a.EventId))
            {
                attendees.Add(a);
            }
        }

        public List<Attendee> GetAttendees(int eventId) =>
            attendees.Where(x => x.EventId == eventId).ToList();
    }
}
