using System.Collections.Generic;

namespace Organizer_Project.Models
{
    public enum ItemSortOrder
    {
        Ascending,
        Descending
    }
    public class ItemSieveDTO
    {
        public ItemPropertyDTO FilterByType { get; }
        public ItemPropertyDTO FilterByText { get; }
        public ItemPropertyDTO FilterByPriority { get; }
        public ItemPropertyDTO FilterByStatus { get; }
        public ItemPropertyDTO FilterByTime { get; }
        public ItemPropertyDTO FilterByEndTime { get; }

        public ItemPropertyDTO SortByText { get; }
        public ItemPropertyDTO SortByPriority { get; }
        public ItemPropertyDTO SortByStatus { get; }
        public ItemPropertyDTO SortByTime { get; }
        public ItemPropertyDTO SortByEndTime { get; }

        public ItemSieveDTO()
        {
            FilterByType = new ItemPropertyDTO(PropertyControlType.ComboBox);
            FilterByText = new ItemPropertyDTO(PropertyControlType.TextBox);
            FilterByPriority = new ItemPropertyDTO(PropertyControlType.ComboBox);
            FilterByStatus = new ItemPropertyDTO(PropertyControlType.ComboBox);
            FilterByTime = new ItemPropertyDTO(PropertyControlType.DateTimePicker);
            FilterByEndTime = new ItemPropertyDTO(PropertyControlType.DateTimePicker);

            SortByText = new ItemPropertyDTO(PropertyControlType.ComboBox);
            SortByPriority = new ItemPropertyDTO(PropertyControlType.ComboBox);
            SortByStatus = new ItemPropertyDTO(PropertyControlType.ComboBox);
            SortByTime = new ItemPropertyDTO(PropertyControlType.ComboBox);
            SortByEndTime = new ItemPropertyDTO(PropertyControlType.ComboBox);
        }

        public IEnumerable<ItemPropertyDTO> GetItems()
        {
            List<ItemPropertyDTO> items = new List<ItemPropertyDTO>();
            if(FilterByType.Value != null)
                items.Add(FilterByType);
            if (FilterByText.Value != null)
                items.Add(FilterByText);
            if(FilterByPriority.Value != null)
                items.Add(FilterByPriority);
            if(FilterByStatus.Value != null)
                items.Add(FilterByStatus);
            if(FilterByTime.Value != null)
                items.Add(FilterByTime);
            if(FilterByEndTime.Value != null)
                items.Add(FilterByEndTime);

            if(SortByText.Value != null)
                items.Add(SortByText);
            if(SortByPriority.Value != null)
                items.Add(SortByPriority);
            if(SortByStatus.Value != null)
                items.Add(SortByStatus);
            if(SortByTime.Value != null)
                items.Add(SortByTime);
            if(SortByEndTime.Value != null)
                items.Add(SortByEndTime);
            
            return items;
        }
    }
}