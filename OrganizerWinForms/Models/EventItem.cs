namespace Organizer_Project.Models
{
    public class EventItem : Interfaces.OrganizerItem
    {
        // Additional properties for Event
        public System.DateTime? EndTime { get; set; }
        public bool IsAllDay { get; set; }
        // Constructors
        public EventItem() : base()
        {
            Type = Interfaces.ItemType.Event;
            EndTime = Time.AddHours(1);
            IsAllDay = true;
        }
        public EventItem(
            string title = null, 
            Interfaces.Priority priority = Interfaces.Priority.Medium, 
            System.DateTime? startTime = null, 
            System.DateTime? endTime = null,
            string notes = null,
            bool isAllDay = false
        ) : base(
            Interfaces.ItemType.Event, 
            title, 
            priority,
            startTime, 
            notes
        )
        {
            EndTime = endTime ?? System.DateTime.Today.AddHours(5);
            IsAllDay = isAllDay;
        }
        public EventItem(EventItem eventItem) : base(eventItem)
        {
            EndTime = eventItem.EndTime;
            IsAllDay = eventItem.IsAllDay;
        }
        public override void UpdateFrom(Interfaces.OrganizerItem item)
        {
            base.UpdateFrom(item);
            if (item is EventItem eventItem)
            {
                EndTime = eventItem.EndTime;
                IsAllDay = eventItem.IsAllDay;
            }
        }
    }
}