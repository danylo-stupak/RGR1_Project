namespace Organizer_Project.Models
{
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
    }
}
