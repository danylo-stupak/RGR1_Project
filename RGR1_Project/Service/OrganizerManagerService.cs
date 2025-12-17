using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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


        // LINQ Operations
        // 1. LINQ Where: Filter by Text (Case insensitive search in Title or Notes)
        public void FilterItems(string filterText, IEnumerable<OrganizerItem> items = null)
        {
            // Start with passed or full list
            IEnumerable<OrganizerItem> query = items ?? Items;
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                string lowerText = filterText.ToLower();
                query = query.Where(item =>
                    (item.Title != null && item.Title.ToLower().Contains(lowerText)) ||
                    (item.Notes != null && item.Notes.ToLower().Contains(lowerText))
                );
            }
        }
        // 2. LINQ Where: Filter by Type (Task vs Event)
        public void FilterItems(ItemType? typeFilter, IEnumerable<OrganizerItem> items = null)
        {
            // Start with passed ot full list
            IEnumerable<OrganizerItem> query = items ?? Items.ToList();
            if (typeFilter.HasValue)
            {
                items = query.Where(item => item.Type == typeFilter.Value);
            }
        }
        // 3. LINQ Where: Filter by Priority
        public void FilterItems(Priority? priorityFilter, IEnumerable<OrganizerItem> items = null)
        {
            // Start with passed ot full list
            IEnumerable<OrganizerItem> query = items ?? Items.ToList();
            if (priorityFilter.HasValue)
            {
                items = query.Where(item => item.Priority == priorityFilter.Value);
            }
        }
        // 3. LINQ Where: Filter by Status (Only for TaskItem)
        public void FilterItems(TaskStatus? statusFilter, IEnumerable<TaskItem> items = null)
        {
            // Start with passed ot full list
            IEnumerable<TaskItem> query = items;
            if (query != null && statusFilter.HasValue)
            {
                items = query.Where(item => item.Status == statusFilter.Value);
            }
        }
        // 4.1 LINQ OrderBy: Sort by Time
        public void SortItems(bool IsAscOrder, IEnumerable<OrganizerItem> items = null)
        {
            // Start with passed ot full list
            IEnumerable<OrganizerItem> query = items ?? Items.ToList();
            items = IsAscOrder ? query.OrderBy(item => item.Time) : query.OrderByDescending(item => item.Time);
        }
        // 4.2 LINQ OrderBy: Sort by EndTime (Only for EventItems)
        public void SortItems(bool IsAscOrder, IEnumerable<EventItem> items = null)
        {
            // Start with passed ot full list
            IEnumerable<EventItem> query = items;
            if (query != null && query.Any())
            {
                items = IsAscOrder ? query.OrderBy(item => item.EndTime) : query.OrderByDescending(item => item.EndTime);
            }
        }
        // Reset back to the original full list
        public void Reset()
        {
            BindingSource.DataSource = Items;
        }
        // Reset to the sorted/filtered list
        public void Reset(IEnumerable<OrganizerItem> items)
        {
            BindingSource.DataSource = items;
        }

        // Extra LINQ: Get Statistics
        public string GetStatistics()
        {
            // Count items
            int totalTasks = Items.Count(i => i.Type == ItemType.Task);
            int totalEvents = Items.Count(i => i.Type == ItemType.Event);

            // Any: Check if there are overdue tasks
            bool hasOverdue = Items.OfType<TaskItem>().Any(t => t.IsOverdue);

            // GroupBy: Group items by priority
            var priorityCounts = Items.GroupBy(i => i.Priority)
                                      .Select(g => $"{g.Key}: {g.Count()}")
                                      .ToList();

            return $"Tasks: {totalTasks}\nEvents: {totalEvents}\nOverdue Exists: {hasOverdue}\n" +
                   string.Join("\n", priorityCounts);
        }
    }
}