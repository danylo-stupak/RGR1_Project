using System;
using System.ComponentModel;

namespace Organizer_Project.Interfaces
{
    public enum ItemType
    {
        Task,
        Event
    }
    public enum Priority
    {
        Low,
        Medium,
        High
    }
    public abstract class OrganizerItem
    {
        public Guid Id { get; set; }
        public ItemType Type { get; set; }
        public Priority Priority { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public DateTime Time { get; set; }


        public OrganizerItem(
            ItemType type,
            string title = null,
            Priority priority = Priority.Medium,
            DateTime? time = null,
            string notes = null
        )
        {
            Id = Guid.NewGuid();
            Type = type;
            Title = title ?? "New " + Enum.GetName(typeof(ItemType), type);
            Priority = priority;
            Time = time ?? DateTime.Today.AddHours(1);
            Notes = notes;
        }
        public OrganizerItem(OrganizerItem item)
        {
            Id = item.Id;
            Type = item.Type;
            Title = item.Title;
            Priority = item.Priority;
            Time = item.Time;
            Notes = item.Notes;
        }

        public virtual void UpdateFrom(OrganizerItem item)
        {
            if (item == null || item.Id != Id)
            {
                throw new ArgumentException("Invalid item to update from.");
            }
            Title = item.Title;
            Priority = item.Priority;
            Time = item.Time;
            Notes = item.Notes;
        }

        public override bool Equals(object obj)
        {
            if (obj is OrganizerItem other)
            {
                return Id.Equals(other.Id);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
}
