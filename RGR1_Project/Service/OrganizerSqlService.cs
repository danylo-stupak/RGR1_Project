using Organizer_Project.Data;
using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

public class OrganizerSqlService : IManagerService<OrganizerItem>
{
    private readonly OrganizerDbContext _context = new OrganizerDbContext();
    public BindingSource BindingSource { get; private set; }

    public OrganizerSqlService()
    {
        BindingSource = new BindingSource();
        RefreshBinding();
    }

    private void RefreshBinding()
    {
        // Fetch everything from DB and put into the BindingSource
        BindingSource.DataSource = _context.Items.ToList();
    }

    public void AddItem(OrganizerItem item)
    {
        _context.Items.Add(item);
        _context.SaveChanges(); // Writes to SQL
        RefreshBinding();
    }

    public void UpdateItem(OrganizerItem item)
    {
        var existing = _context.Items.Find(item.Id);
        if (existing != null)
        {
            _context.Entry(existing).CurrentValues.SetValues(item);
            _context.SaveChanges();
            RefreshBinding();
        }
    }

    public void DeleteItem(OrganizerItem item)
    {
        var existing = _context.Items.Find(item.Id);
        if (existing != null)
        {
            _context.Items.Remove(existing);
            _context.SaveChanges();
            RefreshBinding();
        }
    }

    public IEnumerable<OrganizerItem> GetItems() => _context.Items.AsNoTracking().ToList();

    public void ApplySieve(ItemSieveDTO sieve)
    {
        IQueryable<OrganizerItem> query = _context.Items;
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
            query = query.Where(i => (i as TaskItem).Status == status);
        }

        // Filter by Time
        if (sieve.FilterByTime.IsEnabled && sieve.FilterByTime.Value is DateTime filterTime)
        {
            var time = filterTime.Date;
            query = query.Where(i => DbFunctions.TruncateTime(i.Time) == time);
        }
        // Filter by EndTime (Event-specific property)
        if (sieve.FilterByEndTime.IsEnabled && sieve.FilterByEndTime.Value is DateTime filterEndTime)
        {
            var endTime = filterEndTime.Date;
            // We check if it's a EventItem before comparing status
            query = query.Where(i => i is EventItem && DbFunctions.TruncateTime(((EventItem)i).EndTime) == endTime);
        }

        // --- 2. SORTING (LINQ OrderBy) ---

        // Sort by Time
        if (sieve.SortByTime.IsEnabled && sieve.SortByTime.Value != null)
        {
            bool isAsc = Convert.ToBoolean((ItemSortOrder)sieve.SortByTime.Value);
            query = isAsc ? query.OrderBy(i => i.Time) : query.OrderByDescending(i => i.Time);
        }
        // Sort by EndTime (Event-specific property)
        else if (sieve.SortByEndTime.IsEnabled && sieve.SortByEndTime.Value != null)
        {
            bool isAsc = Convert.ToBoolean((ItemSortOrder)sieve.SortByEndTime.Value);
            // OrderBy needs a value, so we treat non-events as DateTime.MaxValue to push them to the end
            query = isAsc
                ? query.OrderBy(i => (i as EventItem).EndTime ?? DateTime.MaxValue)
                : query.OrderByDescending(i => (i as EventItem).EndTime ?? DateTime.MinValue);
        }

        // --- 3. APPLY TO UI ---
        // Update the BindingSource to refresh the dashboard
        BindingSource.DataSource = query.ToList();
    }

    public void Reset() => RefreshBinding();

    public string GetStatistics()
    {
        // Use the context for stats to avoid loading everything into memory
        int tasks = _context.Items.OfType<TaskItem>().Count();
        int events = _context.Items.OfType<EventItem>().Count();
        return $"Tasks: {tasks}\nEvents: {events}";
    }
}