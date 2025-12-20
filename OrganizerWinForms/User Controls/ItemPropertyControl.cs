using System.Windows.Forms;

namespace Organizer_Project.UserControls
{
    public partial class ItemPropertyControl : UserControl
    {
        private readonly ComboBox PropertyComboBox = null;
        private readonly DateTimePicker PropertyTimePicker = null;
        private readonly TextBox PropertyTextBox = null;
        private readonly Control ctrl = null;
        private object Value
        {
            get
            {
                if (PropertyComboBox != null)
                    return PropertyComboBox.SelectedIndex;
                else if (PropertyTextBox != null)
                    return PropertyTextBox.Text;
                else if (PropertyTimePicker != null)
                    return PropertyTimePicker.Value;
                else return null;
            }
        }
        public event System.EventHandler EnabledToggle;
        private Models.ItemPropertyDTO ItemState { get; set; }
        public ItemPropertyControl(string labelText, Models.ItemPropertyDTO propertyDTO, string[] enumValues = null)
        {
            InitializeComponent();
            ItemState = propertyDTO;
            ItemState.GetData += ItemState_GetData;
            switch (ItemState.Type)
            {
                case Models.PropertyControlType.ComboBox:
                    PropertyComboBox = new ComboBox();
                    if(enumValues != null)
                        PropertyComboBox.Items.AddRange(enumValues);
                    else
                        PropertyComboBox.Items.Add("None");
                    PropertyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    PropertyComboBox.SelectedIndex = 0;
                    PropertyComboBox.SelectedIndexChanged += ItemState_GetData;
                    PropertyComboBox.SelectedIndexChanged += PropertyComboBox_SelectedIndexChanged;

                    PropertyControlPanel.Controls.Add(PropertyComboBox);
                    ctrl = PropertyComboBox;
                    break;
                case Models.PropertyControlType.DateTimePicker:
                    PropertyTimePicker = new DateTimePicker();
                    PropertyControlPanel.Controls.Add(PropertyTimePicker);
                    ctrl = PropertyTimePicker;
                    break;
                case Models.PropertyControlType.TextBox:
                    PropertyTextBox = new TextBox();
                    PropertyTextBox.LostFocus += ItemState_GetData;
                    PropertyControlPanel.Controls.Add(PropertyTextBox);
                    ctrl = PropertyTextBox;
                    break;
            }
            InputNameLabel.Text = labelText;
            ctrl.Dock = DockStyle.Fill;
            ctrl.Enabled = ItemState.IsEnabled;
            EnableCheckBox.Checked = ItemState.IsEnabled;
            EnableCheckBox.CheckedChanged += ItemState_GetData;
            EnableCheckBox.CheckedChanged += EnableCheckBox_CheckedChanged;
        }
        private void PropertyComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            EnabledToggle?.Invoke(this, new System.EventArgs());
        }
        private void ItemState_GetData(object sender, System.EventArgs e)
        {
            ItemState.IsEnabled = EnableCheckBox.Checked;
            ItemState.Value = Value;
        }
        private void EnableCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ctrl.Enabled = EnableCheckBox.Checked;
            ItemState.IsEnabled = EnableCheckBox.Checked;
            EnabledToggle?.Invoke(this, new System.EventArgs());
        }
        private void ItemPropertyControl_Load(object sender, System.EventArgs e)
        {
            ctrl.Enabled = EnableCheckBox.Checked;
        }
    }
}