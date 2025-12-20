using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Organizer_Project.Services
{
    public class OrganizerManagerService : Interfaces.IManagerService<Interfaces.OrganizerItem>
    {
        public BindingSource BindingSource { get; private set; }
        private List<Interfaces.OrganizerItem> Items { get; set; }
        public OrganizerManagerService(IEnumerable<Interfaces.OrganizerItem> bindItems)
        {
            Items = bindItems as List<Interfaces.OrganizerItem> ?? new List<Interfaces.OrganizerItem>();
            BindingSource = new BindingSource();
            BindingSource.DataSource = bindItems;
        }
        public void AddItem(Interfaces.OrganizerItem sender)
        {
            if (sender is Models.TaskItem taskItem)
            {
                Items.Add(taskItem);
            }
            else if (sender is Models.EventItem eventItem)
            {
                Items.Add(eventItem);
            }
            else
            {
                throw new System.ArgumentException("Unable to add item to list: Wrong item type.");
            }
        }
        public void UpdateItem(Interfaces.OrganizerItem sender)
        {

            if (sender is Models.TaskItem taskItem)
            {
                var index = Items.IndexOf(taskItem);
                if (index >= 0)
                {
                    Items[index].UpdateFrom(taskItem);
                }
            }
            else if (sender is Models.EventItem eventItem)
            {
                var index = Items.IndexOf(eventItem);
                if (index >= 0)
                {
                    Items[index].UpdateFrom(eventItem);
                }
            }
            else
            {
                throw new System.ArgumentException("Unable to update item from list: Wrong item type.");
            }
        }
        public void DeleteItem(Interfaces.OrganizerItem sender)
        {
            if (sender is Models.TaskItem taskItem)
            {
                Items.Remove(taskItem);
            }
            else if (sender is Models.EventItem eventItem)
            {
                Items.Remove(eventItem);
            }
            else
            {
                throw new System.ArgumentException("Unable to remove item from list: Wrong item type.");
            }
        }
        public IEnumerable<Interfaces.OrganizerItem> GetItems()
        {
            return Items;
        }
        // LINQ Operations
        public void ApplySieve(Models.ItemSieveDTO sieve)
        {
            // Start with the full list of items
            IEnumerable<Interfaces.OrganizerItem> query = Items;
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
                var type = (Interfaces.ItemType)sieve.FilterByType.Value;
                query = query.Where(i => i.Type == type);
            }
            // Filter by Priority
            if (sieve.FilterByPriority.IsEnabled && sieve.FilterByPriority.Value != null)
            {
                var priority = (Interfaces.Priority)sieve.FilterByPriority.Value;
                query = query.Where(i => i.Priority == priority);
            }
            // Filter by Task Status (Task-specific property)
            if (sieve.FilterByStatus.IsEnabled && sieve.FilterByStatus.Value != null)
            {
                var status = (Models.TaskStatus)sieve.FilterByStatus.Value;
                // We check if it's a Models.TaskItem before comparing status
                query = query.Where(i => i is Models.TaskItem taskItem && taskItem.Status == status);
            }
            // Filter by Time
            if (sieve.FilterByTime.IsEnabled && sieve.FilterByTime.Value is System.DateTime filterTime)
            {
                var time = filterTime.Date;
                query = query.Where(i => i.Time.Date == time);
            }
            // Filter by EndTime (Event-specific property)
            if (sieve.FilterByEndTime.IsEnabled && sieve.FilterByEndTime.Value is System.DateTime filterEndTime)
            {
                var endTime = filterEndTime.Date;
                // We check if it's a Models.EventItem before comparing status
                query = query.Where(i => i is Models.EventItem eventItem && eventItem.EndTime?.Date == endTime);
            }
            // --- 2. SORTING (LINQ OrderBy) ---
            // Sort by Time
            if (sieve.SortByTime.IsEnabled && sieve.SortByTime.Value != null)
            {
                bool isAsc = System.Convert.ToBoolean((Models.ItemSortOrder)sieve.SortByTime.Value);
                query = isAsc? query.OrderBy(i => i.Time) : query.OrderByDescending(i => i.Time);
            }
            // Sort by EndTime (Event-specific property)
            else if (sieve.SortByEndTime.IsEnabled && sieve.SortByEndTime.Value != null)
            {
                bool isAsc = System.Convert.ToBoolean((Models.ItemSortOrder)sieve.SortByEndTime.Value);
                // OrderBy needs a value, so we treat non-events as DateTime.MaxValue to push them to the end
                query = isAsc
                    ? query.OrderBy(i => i is Models.EventItem e ? e.EndTime : System.DateTime.MaxValue)
                    : query.OrderByDescending(i => i is Models.EventItem e ? e.EndTime : System.DateTime.MinValue);
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
        public void Reset(IEnumerable<Interfaces.OrganizerItem> items)
        {
            BindingSource.DataSource = items;
        }
        // Extra LINQ: Get Statistics
        public string GetStatistics()
        {
            // Count items
            int totalTasks = Items.Count(i => i.Type == Interfaces.ItemType.Task);
            int totalEvents = Items.Count(i => i.Type == Interfaces.ItemType.Event);
            // Any: Check if there are overdue tasks
            bool hasOverdue = Items.OfType<Models.TaskItem>().Any(t => t.IsOverdue);
            // GroupBy: Group items by priority
            var priorityCounts = Items.GroupBy(i => i.Priority)
                                      .Select(g => $"{g.Key}: {g.Count()}")
                                      .ToList();
            return $"Tasks: {totalTasks}\nEvents: {totalEvents}\nOverdue Exists: {hasOverdue}\n" +
                   string.Join("\n", priorityCounts);
        }
    }
}