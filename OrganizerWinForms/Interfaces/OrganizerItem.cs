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
        public System.Guid Id { get; set; }
        public ItemType? Type { get; set; }
        public Priority Priority { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public System.DateTime Time { get; set; }
        // Constructors
        public OrganizerItem()
        {
            Id = System.Guid.NewGuid();
            Type = null;
            Priority = Priority.Low;
            Title = null;
            Notes = null;
            Time = System.DateTime.Today;
        }
        public OrganizerItem(
            ItemType type,
            string title = null,
            Priority priority = Priority.Medium,
            System.DateTime? time = null,
            string notes = null
        )
        {
            Id = System.Guid.NewGuid();
            Type = type;
            Title = title ?? "New " + System.Enum.GetName(typeof(ItemType), type);
            Priority = priority;
            Time = time ?? System.DateTime.Today;
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
                throw new System.ArgumentException("Invalid item to update from.");
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
