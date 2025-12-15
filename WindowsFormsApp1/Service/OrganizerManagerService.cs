using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Organizer_Project.Services
{
    public class OrganizerManagerService : IManagerService<OrganizerItem>
    {
        public BindingSource BindingSource { get; private set; }
        private List<OrganizerItem> Items { get; set; }
        public OrganizerManagerService(IEnumerable<OrganizerItem> bindItems)
        {
            Items = bindItems as List<OrganizerItem> ?? new List<OrganizerItem>();
            BindingSource = new BindingSource();
            BindingSource.DataSource = bindItems;
        }
        public void AddItem(OrganizerItem sender)
        {
            if (sender is TaskItem taskItem)
            {
                Items.Add(taskItem);
            }
            else if (sender is EventItem eventItem)
            {
                Items.Add(eventItem);
            }
            else
            {
                throw new ArgumentException("Unable to add item to list: Wrong item type.");
            }
        }
        public void UpdateItem(OrganizerItem sender)
        {

            if (sender is TaskItem taskItem)
            {
                var index = Items.IndexOf(taskItem);
                if (index >= 0)
                {
                    Items[index].UpdateFrom(taskItem);
                }
            }
            else if (sender is EventItem eventItem)
            {
                var index = Items.IndexOf(eventItem);
                if (index >= 0)
                {
                    Items[index].UpdateFrom(eventItem);
                }
            }
            else
            {
                throw new ArgumentException("Unable to update item from list: Wrong item type.");
            }
        }
        public void DeleteItem(OrganizerItem sender)
        {
            if (sender is TaskItem taskItem)
            {
                Items.Remove(taskItem);
            }
            else if (sender is EventItem eventItem)
            {
                Items.Remove(eventItem);
            }
            else
            {
                throw new ArgumentException("Unable to remove item from list: Wrong item type.");
            }
        }
        public IEnumerable<OrganizerItem> GetItems()
        {
            return Items;
        }
    }
}
