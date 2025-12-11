using System;
using Organizer_Project.Interfaces;
namespace Organizer_Project.Models
{
    public class EventItem : OrganizerItem
    {
        // Additional properties for Event
        public DateTime EndTime { get; set; }
        public bool IsAllDay { get; set; }

        // Constructor

        public EventItem(
            string title = null, 
            Priority priority = Priority.Medium, 
            DateTime? startTime = null, 
            DateTime? endTime = null,
            string notes = null,
            bool isAllDay = false
        ) : base(
            ItemType.Event, 
            title, 
            priority,
            endTime, 
            notes
        )
        {
            EndTime = endTime ?? DateTime.Today;
            IsAllDay = isAllDay;
        }

        public EventItem(EventItem eventItem) : base(eventItem)
        {
            EndTime = eventItem.EndTime;
            IsAllDay = eventItem.IsAllDay;
        }
    }

}
