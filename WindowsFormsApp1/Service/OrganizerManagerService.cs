using Organizer_Project.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;


namespace Organizer_Project.Services
{
    public class OrganizerManagerService : IManagerService<OrganizerItem>
    {
        private BindingList<OrganizerItem> Items;

        public OrganizerManagerService(IEnumerable<OrganizerItem> bindItems)
        {
            Items = new BindingList<OrganizerItem>(new List<OrganizerItem>(bindItems));
        }

        public void AddItem(OrganizerItem sender)
        {
            if (sender != null)
            {
                Items.Add(sender);
            }
        }

        public void UpdateItem(OrganizerItem sender)
        {
            if (sender != null)
            {
                var index = Items.IndexOf(sender);
                if (index >= 0)
                {
                    Items[index].UpdateFrom(sender);
                }
            }
        }

        public void DeleteItem(OrganizerItem sender)
        {
            if (sender != null)
            {
                Items.Remove(sender);
            }
        }

        public IEnumerable<OrganizerItem> GetItems()
        {
            return Items;
        }
    }
}
