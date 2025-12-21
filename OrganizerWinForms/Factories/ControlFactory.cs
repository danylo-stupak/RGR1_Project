using System.Windows.Forms;

namespace Organizer_Project.Factories
{
    public static class ControlFactory
    {
        // generate item control with copy of preloaded data
        public static Interfaces.IOrganizerItemControl CreateControl(BindingSource source, int position, bool IsEditMode = false)
        {
            var item = source[position];
            if (item is Models.TaskItem)
            {
                return new UserControls.TaskItemControl(source, position, IsEditMode);   // pass a original bindingsource
            }
            if (item is Models.EventItem)
            {
                return new UserControls.EventItemControl(source, position, IsEditMode);  // pass a original bindingsource
            }
            return null;
        }
        // generate an control with default data
        public static Interfaces.IOrganizerItemControl CreateControl(Interfaces.ItemType type, bool IsEditMode = false)
        {
            switch (type)
            {
                case Interfaces.ItemType.Task:
                    var taskSource = new BindingSource();
                    taskSource.DataSource = new Models.TaskItem();
                    return new UserControls.TaskItemControl(taskSource, 0, IsEditMode);
                case Interfaces.ItemType.Event:
                    var eventSource = new BindingSource();
                    eventSource.DataSource = new Models.EventItem();
                    return new UserControls.EventItemControl(eventSource, 0, IsEditMode);
                default: return null;
            }
        }
    }
}
