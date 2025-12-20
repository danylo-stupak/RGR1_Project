namespace Organizer_Project.Models
{
    public enum TaskStatus { New, InProgress, Done, Cancelled }
    public class TaskItem : Interfaces.OrganizerItem
    {
        // Additional properties for Task
        public TaskStatus? Status { get; set; } = TaskStatus.New;
        public string Group { get; set; }
        public bool IsOverdue 
        {
            get
            {
                return  Status != TaskStatus.Done &&
                        System.DateTime.Now > Time;
            }
        }
        // Constructors
        public TaskItem() : base()
        {
            Status = TaskStatus.New;
            Group = null;
        }
        public TaskItem(
            string title = null,
            Interfaces.Priority priority = Interfaces.Priority.Medium,
            System.DateTime? endTime = null,
            TaskStatus status = TaskStatus.New,
            string group = null,
            string notes = null
        ) : base(
                Interfaces.ItemType.Task,
                title,
                priority,
                endTime,
                notes
            )
        {
            Status = status;
            Group = group;
            Notes = notes;
        }
        public TaskItem(TaskItem taskItem) : base(taskItem)
        {
            Status = taskItem.Status;
            Group = taskItem.Group;
        }
        public override void UpdateFrom(Interfaces.OrganizerItem item)
        {
            base.UpdateFrom(item);
            if (item is TaskItem taskItem)
            {
                Status = taskItem.Status;
                Group = taskItem.Group;
            }
        }
    }
}
