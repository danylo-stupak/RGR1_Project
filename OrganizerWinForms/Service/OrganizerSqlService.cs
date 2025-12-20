using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Organizer_Project.Services
{
    public class OrganizerSqlService : Interfaces.IManagerService<Interfaces.OrganizerItem>
    {
        private readonly Data.OrganizerDbContext OrganizerContext = new Data.OrganizerDbContext();
        public BindingSource BindingSource { get; private set; }
        public OrganizerSqlService()
        {
            BindingSource = new BindingSource();
            RefreshBinding();
        }
        private void RefreshBinding()
        {
            // Fetch everything from DB and put into the BindingSource
            BindingSource.DataSource = OrganizerContext.Items.ToList();
        }
        public void AddItem(Interfaces.OrganizerItem item)
        {
            OrganizerContext.Items.Add(item);
            OrganizerContext.SaveChanges(); // Writes to SQL
            RefreshBinding();
        }
        public void UpdateItem(Interfaces.OrganizerItem item)
        {
            var existing = OrganizerContext.Items.Find(item.Id);
            if (existing != null)
            {
                OrganizerContext.Entry(existing).CurrentValues.SetValues(item);
                OrganizerContext.SaveChanges();
                RefreshBinding();
            }
        }
        public void DeleteItem(Interfaces.OrganizerItem item)
        {
            var existing = OrganizerContext.Items.Find(item.Id);
            if (existing != null)
            {
                OrganizerContext.Items.Remove(existing);
                OrganizerContext.SaveChanges();
                RefreshBinding();
            }
        }
        public IEnumerable<Interfaces.OrganizerItem> GetItems() => OrganizerContext.Items.AsNoTracking().ToList();
        public void ApplySieve(Models.ItemSieveDTO sieve)
        {
            IQueryable<Interfaces.OrganizerItem> query = OrganizerContext.Items;
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
            // Filtex by Priority
            if (sieve.FilterByPriority.IsEnabled && sieve.FilterByPriority.Value != null)
            {
                var priority = (Interfaces.Priority)sieve.FilterByPriority.Value;
                query = query.Where(i => i.Priority == priority);
            }
            // Filter by Task Status (Task-specific property)
            if (sieve.FilterByStatus.IsEnabled && sieve.FilterByStatus.Value != null)
            {
                var status = (Models.TaskStatus)sieve.FilterByStatus.Value;
                // We check if it's a TaskItem before comparing status
                query = query.Where(i => (i as Models.TaskItem).Status == status);
            }
            // Filter by Time
            if (sieve.FilterByTime.IsEnabled && sieve.FilterByTime.Value is System.DateTime filterTime)
            {
                var time = filterTime.Date;
                query = query.Where(i => DbFunctions.TruncateTime(i.Time) == time);
            }
            // Filter by EndTime (Event-specific property)
            if (sieve.FilterByEndTime.IsEnabled && sieve.FilterByEndTime.Value is System.DateTime filterEndTime)
            {
                var endTime = filterEndTime.Date;
                // We check if it's a EventItem before comparing status
                query = query.Where(i => i is Models.EventItem && DbFunctions.TruncateTime(((Models.EventItem)i).EndTime) == endTime);
            }
            // --- 2. SORTING (LINQ OrderBy) ---
            // Sort by Time
            if (sieve.SortByTime.IsEnabled && sieve.SortByTime.Value != null)
            {
                bool isAsc = System.Convert.ToBoolean((Models.ItemSortOrder)sieve.SortByTime.Value);
                query = isAsc ? query.OrderBy(i => i.Time) : query.OrderByDescending(i => i.Time);
            }
            // Sort by EndTime (Event-specific property)
            else if (sieve.SortByEndTime.IsEnabled && sieve.SortByEndTime.Value != null)
            {
                bool isAsc = System.Convert.ToBoolean((Models.ItemSortOrder)sieve.SortByEndTime.Value);
                // OrderBy needs a value, so we treat non-events as DateTime.MaxValue to push them to the end
                query = isAsc
                    ? query.OrderBy(i => (i as Models.EventItem).EndTime ?? System.DateTime.MaxValue)
                    : query.OrderByDescending(i => (i as Models.EventItem).EndTime ?? System.DateTime.MinValue);
            }
            // --- 3. APPLY TO UI ---
            // Update the BindingSource to refresh the dashboard
            BindingSource.DataSource = query.ToList();
        }
        public void Reset() => RefreshBinding();
        public void Clear()
        {
            // Efficiently truncates the table
            OrganizerContext.Database.ExecuteSqlCommand("DELETE FROM [OrganizerItems]");
            OrganizerContext.SaveChanges();
            RefreshBinding();
        }
        public string GetStatistics()
        {
            // Use the context for stats to avoid loading everything into memory
            int tasks = OrganizerContext.Items.OfType<Models.TaskItem>().Count();
            int events = OrganizerContext.Items.OfType<Models.EventItem>().Count();
            return $"Tasks: {tasks}\nEvents: {events}";
        }
    }
}