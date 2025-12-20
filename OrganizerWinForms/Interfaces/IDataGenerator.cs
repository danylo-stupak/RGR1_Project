using System.Collections.Generic;

namespace Organizer_Project.Interfaces
{
    public interface IDataGenerator<T>
    {
        IEnumerable<T> GenerateDataList(int listLength);
        T GenerateData();
    }
}