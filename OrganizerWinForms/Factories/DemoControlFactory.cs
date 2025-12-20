using System.Windows.Forms;

namespace Organizer_Project.Factories
{
    public static class DemoControlFactory
    {
        public static Interfaces.IOrganizerItemDemoControl CreateDemoControl(BindingSource source, int position)
        {
            var item = source[position];
            if (item is Models.TaskItem taskItem)
            {
                var taskSource = new BindingSource();
                taskSource.DataSource = taskItem;
                return new UserControls.TaskItemDemoControl(taskSource, position);
            }
            if (item is Models.EventItem eventItem)
            {
                var eventSource = new BindingSource();
                eventSource.DataSource = eventItem;
                return new UserControls.EventItemDemoControl(eventSource, position);
            }
            return null;
        }
    }
}
