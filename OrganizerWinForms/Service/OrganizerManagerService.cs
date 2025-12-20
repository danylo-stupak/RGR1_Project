using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
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
        public void ApplySieve(ItemSieveDTO sieve)
        {
            // Start with the full list of items
            IEnumerable<OrganizerItem> query = Items;

            // --- 1. FILTERING (Sequential LINQ Where) ---

            // Filter by Text (Title/Notes)
            if (sieve.FilterByText.IsEnabled && sieve.FilterByText.Value != null)
            {
                string text = sieve.FilterByText.Value.ToString().ToLower();
                query = query.Where(i =>
                    (i.Title != null && i.Title.ToLower().Contains(text)) ||
                    (i.Notes != null && i.Notes.ToLower().Contains(text)));
            }

            // Filter by Type (Task vs Event)
            if (sieve.FilterByType.IsEnabled && sieve.FilterByType.Value != null)
            {
                var type = (ItemType)sieve.FilterByType.Value;
                query = query.Where(i => i.Type == type);
            }

            // Filter by Priority
            if (sieve.FilterByPriority.IsEnabled && sieve.FilterByPriority.Value != null)
            {
                var priority = (Priority)sieve.FilterByPriority.Value;
                query = query.Where(i => i.Priority == priority);
            }

            // Filter by Task Status (Task-specific property)
            if (sieve.FilterByStatus.IsEnabled && sieve.FilterByStatus.Value != null)
            {
                var status = (TaskStatus)sieve.FilterByStatus.Value;
                // We check if it's a TaskItem before comparing status
                query = query.Where(i => i is TaskItem taskItem && taskItem.Status == status);
            }

            // Filter by Time
            if (sieve.FilterByTime.IsEnabled && sieve.FilterByTime.Value is DateTime filterTime)
            {
                var time = filterTime.Date;
                query = query.Where(i => i.Time.Date == time);
            }
            // Filter by EndTime (Event-specific property)
            if (sieve.FilterByEndTime.IsEnabled && sieve.FilterByEndTime.Value is DateTime filterEndTime)
            {
                var endTime = filterEndTime.Date;
                // We check if it's a EventItem before comparing status
                query = query.Where(i => i is EventItem eventItem && eventItem.EndTime?.Date == endTime);
            }

            // --- 2. SORTING (LINQ OrderBy) ---

            // Sort by Time
            if (sieve.SortByTime.IsEnabled && sieve.SortByTime.Value != null)
            {
                bool isAsc = Convert.ToBoolean((ItemSortOrder)sieve.SortByTime.Value);
                query = isAsc? query.OrderBy(i => i.Time) : query.OrderByDescending(i => i.Time);
            }
            // Sort by EndTime (Event-specific property)
            else if (sieve.SortByEndTime.IsEnabled && sieve.SortByEndTime.Value != null)
            {
                bool isAsc = Convert.ToBoolean((ItemSortOrder)sieve.SortByEndTime.Value);
                // OrderBy needs a value, so we treat non-events as DateTime.MaxValue to push them to the end
                query = isAsc
                    ? query.OrderBy(i => i is EventItem e ? e.EndTime : DateTime.MaxValue)
                    : query.OrderByDescending(i => i is EventItem e ? e.EndTime : DateTime.MinValue);
            }

            // --- 3. APPLY TO UI ---
            // Update the BindingSource to refresh the dashboard
            BindingSource.DataSource = query.ToList();
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