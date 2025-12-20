using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer_Project.Interfaces
{
    public interface IManagerAsyncService<T> where T : class
    {
        // Basic operations
        BindingSource BindingSource { get; }
        Task AddItemAsync(T sender);
        Task UpdateItemAsync(T sender);
        Task DeleteItemAsync(T sender);
        Task<IEnumerable<T>> GetItemsAsync();

        // LINQ operations
        Task ApplySieveAsync(Models.ItemSieveDTO sieve);
        Task ResetAsync();
        Task<string> GetStatisticsAsync();
    }
}