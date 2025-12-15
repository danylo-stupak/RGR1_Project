using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using Organizer_Project.User_Controls;
using System.Windows.Forms;

namespace Organizer_Project.Factories
{
    public static class ControlFactory
    {
        // generate item control with copy of preloaded data
        public static IOrganizerItemControl CreateControl(BindingSource source, int position, bool IsEditMode = false)
        {
            var item = source[position];
            if (item is TaskItem)
            {
                return new TaskItemControl(source, position, IsEditMode);   // pass a original bindingsource
            }
            if (item is EventItem)
            {
                return new EventItemControl(source, position, IsEditMode);  // pass a original bindingsource
            }
            return null;
        }
        // generate an control with default data
        public static IOrganizerItemControl CreateControl(ItemType type, bool IsEditMode = false)
        {
            switch (type)
            {
                case ItemType.Task:
                    var taskSource = new BindingSource();
                    taskSource.DataSource = new TaskItem();
                    return new TaskItemControl(taskSource, 0, IsEditMode);
                case ItemType.Event:
                    var eventSource = new BindingSource();
                    eventSource.DataSource = new EventItem();
                    return new EventItemControl(eventSource, 0, IsEditMode);
                default: return null;
            }
        }
    }
}
