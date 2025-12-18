using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class ItemPropertyControl : UserControl
    {
        private static readonly string[] DefaultLabelText = { "Enter Text:", "Choose an option:", "Pick a date:"};
        private readonly ComboBox PropertyComboBox = null;
        private readonly DateTimePicker PropertyTimePicker = null;
        private readonly TextBox PropertyTextBox = null;
        private readonly Control ctrl = null;

        public event EventHandler EnabledToggle;
        private ItemPropertyDTO ItemState { get; set; }
        public ItemPropertyControl(ItemPropertyDTO propertyDTO, string[] enumValues = null)
        {
            InitializeComponent();
            ItemState = propertyDTO;
            switch (ItemState.Type)
            {
                case PropertyControlType.ComboBox:
                    PropertyComboBox = new ComboBox();
                    if(enumValues != null)
                        PropertyComboBox.Items.AddRange(enumValues);
                    else
                        PropertyComboBox.Items.Add("None");
                    PropertyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    PropertyComboBox.SelectedIndex = 0;
                    PropertyComboBox.SelectedIndexChanged += PropertyComboBox_SelectedIndexChanged;
                    PropertyControlPanel.Controls.Add(PropertyComboBox);
                    ctrl = PropertyComboBox;
                    break;
                case PropertyControlType.DateTimePicker:
                    PropertyTimePicker = new DateTimePicker();
                    PropertyControlPanel.Controls.Add(PropertyTimePicker);
                    ctrl = PropertyTimePicker;
                    break;
                case PropertyControlType.TextBox:
                    PropertyTextBox = new TextBox();
                    PropertyTextBox.LostFocus += PropertyTextBox_LostFocus;
                    PropertyControlPanel.Controls.Add(PropertyTextBox);
                    ctrl = PropertyTextBox;
                    break;
            }
            ctrl.Dock = DockStyle.Fill;
            InputNameLabel.Text = DefaultLabelText[(int)ItemState.Type];
            EnableCheckBox.Checked = ItemState.IsEnabled;
        }
        private void PropertyTextBox_LostFocus(object sender, EventArgs e)
        {
            ItemState_PropertyUpdate();
        }
        private void ItemState_PropertyUpdate()
        {
            if (PropertyComboBox != null)
                ItemState.Value = PropertyComboBox.SelectedIndex;
            else if (PropertyTextBox != null)
                ItemState.Value = PropertyTextBox.Text;
            else if (PropertyTimePicker != null)
                ItemState.Value = PropertyTimePicker.Value;
            else ItemState.Value = null;
        }
        private void EnableCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ctrl.Enabled = EnableCheckBox.Checked;
            ItemState.IsEnabled = EnableCheckBox.Checked;
            ItemState_PropertyUpdate();
            EnabledToggle?.Invoke(this, new EventArgs());
        }
        private void PropertyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemState_PropertyUpdate();
            EnabledToggle?.Invoke(this, new EventArgs());
        }
        private void ItemPropertyControl_Load(object sender, EventArgs e)
        {
            ctrl.Enabled = EnableCheckBox.Checked;
        }
    }
}