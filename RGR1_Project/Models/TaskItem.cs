using Organizer_Project.Interfaces;
using System;

namespace Organizer_Project.Models
{
    public enum TaskStatus { New, InProgress, Done, Cancelled }
    public class TaskItem : OrganizerItem
    {
        // Additional properties for Task
        public TaskStatus? Status { get; set; } = TaskStatus.New;
        public string Group { get; set; }
        public bool IsOverdue 
        {
            get
            {
                return  Status != TaskStatus.Done &&
                        DateTime.Now > Time;
            }
        }

        public TaskItem(
            string title = null,
            Priority priority = Priority.Medium,
            DateTime? endTime = null,
            TaskStatus status = TaskStatus.New,
            string group = null,
            string notes = null
        ) : base(
                ItemType.Task,
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

        public override void UpdateFrom(OrganizerItem item)
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
