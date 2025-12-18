using System;

namespace Organizer_Project.Models
{
    public enum PropertyControlType
    {
        TextBox,
        ComboBox,
        DateTimePicker
    }
    public class ItemPropertyDTO
    {
        private object _value;
        public bool IsEnabled { get; set; }
        public PropertyControlType Type { get; set; }
        public object Value { get { return IsEnabled ? _value : null; } set { _value = value; } }

        public ItemPropertyDTO(PropertyControlType type, bool isEnabled = false)
        {
            _value = null;
            IsEnabled = isEnabled;
            Type = type;
        }
    }
}
