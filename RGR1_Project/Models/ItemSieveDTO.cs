using System.Collections.Generic;

namespace Organizer_Project.Models
{
    public enum ItemSortOrder
    {
        Descending,
        Ascending
    }
    public class ItemSieveDTO
    {
        public ItemPropertyDTO FilterByType { get; }
        public ItemPropertyDTO FilterByText { get; }
        public ItemPropertyDTO FilterByPriority { get; }
        public ItemPropertyDTO FilterByTime { get; }
        public ItemPropertyDTO FilterByStatus { get; }
        public ItemPropertyDTO FilterByEndTime { get; }
        public ItemPropertyDTO SortByTime { get; }
        public ItemPropertyDTO SortByEndTime { get; }

        public ItemSieveDTO()
        {
            FilterByType = new ItemPropertyDTO(PropertyControlType.ComboBox);
            FilterByText = new ItemPropertyDTO(PropertyControlType.TextBox);
            FilterByPriority = new ItemPropertyDTO(PropertyControlType.ComboBox);
            FilterByTime = new ItemPropertyDTO(PropertyControlType.DateTimePicker);

            FilterByStatus = new ItemPropertyDTO(PropertyControlType.ComboBox);
            FilterByEndTime = new ItemPropertyDTO(PropertyControlType.DateTimePicker);
            
            SortByTime = new ItemPropertyDTO(PropertyControlType.ComboBox);
            SortByEndTime = new ItemPropertyDTO(PropertyControlType.ComboBox);
        }
        public override bool Equals(object obj)
        {
            if (obj is ItemSieveDTO itemSieveDTO)
            {
                return FilterByType.Equals(itemSieveDTO.FilterByType) &&
                    FilterByText.Equals(itemSieveDTO.FilterByText) &&
                    FilterByPriority.Equals(itemSieveDTO.FilterByPriority) &&
                    FilterByTime.Equals(itemSieveDTO.FilterByTime) &&
                    FilterByStatus.Equals(itemSieveDTO.FilterByStatus) &&
                    FilterByEndTime.Equals(itemSieveDTO.FilterByEndTime) &&
                    SortByTime.Equals(itemSieveDTO.SortByTime) &&
                    SortByEndTime.Equals(itemSieveDTO.SortByEndTime);
            }
            else
            {
                return false;
            }
        }
        public void Update()
        {
            FilterByType.GetItem();
            FilterByText.GetItem();
            FilterByPriority.GetItem();
            FilterByTime.GetItem();
            FilterByStatus.GetItem();
            FilterByEndTime.GetItem();
            SortByTime.GetItem();
            SortByEndTime.GetItem();
            SortByEndTime.GetItem();
        }

        public override int GetHashCode()
        {
            int hashCode = 867270195;
            hashCode = hashCode * -1521134295 + EqualityComparer<ItemPropertyDTO>.Default.GetHashCode(FilterByType);
            return hashCode;
        }
    }
}
