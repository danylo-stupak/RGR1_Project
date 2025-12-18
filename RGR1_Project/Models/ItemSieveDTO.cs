namespace Organizer_Project.Models
{
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
    }
}
