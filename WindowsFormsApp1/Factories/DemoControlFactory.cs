using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using Organizer_Project.User_Controls;
using System.Windows.Forms;

namespace Organizer_Project.Factories
{
    public static class DemoControlFactory
    {
        public static IOrganizerItemDemoControl CreateDemoControl(BindingSource source, int position)
        {
            var item = source[position];
            if (item is TaskItem taskItem)
            {
                var taskSource = new BindingSource();
                taskSource.DataSource = taskItem;
                return new TaskItemDemoControl(taskSource, position);
            }
            if (item is EventItem eventItem)
            {
                var eventSource = new BindingSource();
                eventSource.DataSource = eventItem;
                return new EventItemDemoControl(eventSource, position);
            }
            return null;
        }
    }
}
