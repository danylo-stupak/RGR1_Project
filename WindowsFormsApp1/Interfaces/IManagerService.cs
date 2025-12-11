using System;
using System.Collections.Generic;

namespace Organizer_Project.Interfaces
{
    public interface IManagerService<T> where T : class
    {
        void AddItem(T sender);
        void UpdateItem(T sender);
        void DeleteItem(T sender);
        IEnumerable<T> GetItems();
    }
}