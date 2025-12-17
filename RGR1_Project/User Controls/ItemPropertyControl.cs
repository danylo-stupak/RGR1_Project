using System;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class ItemPropertyControl : UserControl
    {
        private static string[] InputType = { "Enter Text:", "Choose an option:", "Pick a date:"};
        public event EventHandler EnabledToggle;
        public PropertyType Type;
        public bool IsEnabled {
            get
            {
                return EnableCheckBox.Checked;
            }
        }
        public object Value
        {
            get
            {
                if(!IsEnabled)
                    return null;
                else if (PropertyComboBox.Enabled)
                {
                    return PropertyComboBox.SelectedValue;
                }
                else if (PropertyTextBox.Enabled)
                {
                    return PropertyTextBox.Text;
                }
                else if (PropertyTimePicker.Enabled)
                {
                    return PropertyTimePicker.Value;
                }
                else
                {
                    return null;
                }
            }
        }
        public ItemPropertyControl(PropertyType property, string labelText = null)
        {
            InitializeComponent();
            Type = property;
            InputNameLabel.Text = labelText ?? InputType[(int)Type];
        }
        public ItemPropertyControl(PropertyType property, string[] enumValues, string labelText = null)
        {
            InitializeComponent();
            Type = property;
            InputNameLabel.Text = labelText ?? InputType[(int)Type];
            PropertyComboBox.Items.Clear();
            PropertyComboBox.Items.AddRange(enumValues);
            PropertyComboBox.SelectedIndex = 0;
        }
        private void FilterItemProperty_Load(object sender, System.EventArgs e)
        {
            PropertyTextBox.Enabled = Type == PropertyType.Text;
            PropertyComboBox.Enabled = Type == PropertyType.Enum;
            PropertyTimePicker.Enabled = Type == PropertyType.Date;


            PropertyTextBox.Visible = Type == PropertyType.Text;
            PropertyComboBox.Visible = Type == PropertyType.Enum;
            PropertyTimePicker.Visible = Type == PropertyType.Date;

            EnableCheckBox.Checked = false;
            ControlsFlowLayout.Enabled = IsEnabled;
        }
        private void EnableCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ControlsFlowLayout.Enabled = IsEnabled;
            EnabledToggle?.Invoke(this, new EventArgs());
        }
    }
    public enum PropertyType
    {
        Text,
        Enum,
        Date
    }
}
