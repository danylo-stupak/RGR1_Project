using System.Collections.Generic;
using System.Windows.Forms;

namespace Organizer_Project.Interfaces
{
    public interface IManagerService<T> where T : class
    {
        // Basic operations
        BindingSource BindingSource { get; }
        void AddItem(T sender);
        void UpdateItem(T sender);
        void DeleteItem(T sender);
        IEnumerable<T> GetItems();

        // LINQ operations
        void FilterItems(string filterText, IEnumerable<T> items = null);
        void SortItems(bool IsAscOrder, IEnumerable<T> items = null);
        void Reset();
        void Reset(IEnumerable<T> items);
        string GetStatistics();
    }
}