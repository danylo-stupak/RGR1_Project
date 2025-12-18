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
        public User_Controls.ItemPropertyControl control { private get; set; }
        public bool IsEnabled { get; set; }
        public PropertyControlType Type { get; set; }
        public object Value { get; set; }
        public event EventHandler GetData;
        public ItemPropertyDTO(PropertyControlType type, bool isEnabled = false)
        {
            Value = null;
            IsEnabled = isEnabled;
            Type = type;
        }
        public override bool Equals(object obj)
        {
            if(obj is ItemPropertyDTO itemPropertyDTO)
            {
                return IsEnabled.Equals(itemPropertyDTO.IsEnabled) &&
                        Type.Equals(itemPropertyDTO.Type);
            }
            else
            {
                return false;
            }
        }
        public void GetItem()
        {
            GetData?.DynamicInvoke(control, EventArgs.Empty);
        }

        public override int GetHashCode()
        {
            return 2049151605 + Type.GetHashCode();
        }
    }
}
