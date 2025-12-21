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
        void ApplySieve(Models.ItemSieveDTO sieve);
        void Reset();
        void Clear();
        string GetStatistics();
    }
}