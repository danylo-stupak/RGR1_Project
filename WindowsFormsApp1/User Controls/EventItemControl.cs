using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Organizer_Project.User_Controls
{
    public partial class EventItemControl : UserControl, IOrganizerItemControl
    {
        private BindingSource EventBindingSource;
        private bool IsEditMode = true;
        public EventItemControl(EventItem eventItem, bool editMode = false)
        {
            var eventItemCopy = new EventItem(eventItem); // Create a copy to avoid modifying the original until saved
            InitializeComponent();
            EventBindingSource = new BindingSource
            {
                DataSource = eventItemCopy
            };
            IsEditMode = editMode;
        }
        public OrganizerItem GetItem()
        {
            EventBindingSource.EndEdit();
            return (EventItem)EventBindingSource.DataSource;
        }

        public void ToggleMode(bool isEditMode)
        {
            IsEditMode = isEditMode;
            ToggleControlsEnabled();
        }
        private void ToggleControlsEnabled()
        {
            MainFlowLayout.Hide();
            MainFlowLayout.SuspendLayout();
            EditModeLayout.Visible = IsEditMode;
            EditModeLayout.Enabled = IsEditMode;

            ViewModeLayout.Visible = !IsEditMode;
            ViewModeLayout.Enabled = !IsEditMode;

            MainFlowLayout.Controls.Clear();
            MainFlowLayout.Controls.Add(IsEditMode ? EditModeLayout : ViewModeLayout);

            MainFlowLayout.ResumeLayout();
            MainFlowLayout.Show();
        }

        private void ConfigureDateTimePickers()
        {
            string format = AllDayCheckBox_Edit.Checked ? "ddd, dd MMM" : "ddd, dd MMM - HH:mm";
            MainTimePicker.CustomFormat = format;
            EndTimePicker.CustomFormat = format;
        }
        private void BindData()
        {
            TitleTextBox.DataBindings.Add("Text", EventBindingSource, "Title", true, DataSourceUpdateMode.OnValidation);
            PriorityComboBox.DataBindings.Add("SelectedValue", EventBindingSource, "Priority", true, DataSourceUpdateMode.OnPropertyChanged);
            MainTimePicker.DataBindings.Add("Value", EventBindingSource, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            EndTimePicker.DataBindings.Add("Value", EventBindingSource, "EndTime", true, DataSourceUpdateMode.OnValidation);
            AllDayCheckBox_Edit.DataBindings.Add("Checked", EventBindingSource, "IsAllDay", true, DataSourceUpdateMode.OnPropertyChanged);
            NotesRichTextBox.DataBindings.Add("Text", EventBindingSource, "Notes", true, DataSourceUpdateMode.OnPropertyChanged);

            TitleLabel.DataBindings.Add("Text", EventBindingSource, "Title", true, DataSourceUpdateMode.Never);
            PriorityLabel.DataBindings.Add("Text", EventBindingSource, "Priority", true, DataSourceUpdateMode.Never);
            MainTimeLabel.DataBindings.Add("Text", EventBindingSource, "Time", true, DataSourceUpdateMode.Never);
            EndTimeLabel.DataBindings.Add("Text", EventBindingSource, "Time", true, DataSourceUpdateMode.Never);
            AllDayCheckBox_View.DataBindings.Add("Checked", EventBindingSource, "IsAllDay", true, DataSourceUpdateMode.Never);
            NotesLabel.DataBindings.Add("Text", EventBindingSource, "Notes", true, DataSourceUpdateMode.Never);
        }
        private void ConfigureComboBoxes()
        {
            var priorities = new List<KeyValuePair<string, Priority>>
            {
                new KeyValuePair<string, Priority>("Low", Priority.Low),
                new KeyValuePair<string, Priority>("Medium", Priority.Medium),
                new KeyValuePair<string, Priority>("High", Priority.High)
            };

            PriorityComboBox.DataSource = priorities;
            PriorityComboBox.DisplayMember = "Key";
            PriorityComboBox.ValueMember = "Value";
        }
        private void EventControl_Load(object sender, System.EventArgs e)
        {
            ConfigureComboBoxes();
            BindData();
            ToggleMode(IsEditMode);
        }

        private void AllDayCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ConfigureDateTimePickers();
        }

        private void TitleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is TextBox titleTextBox)
            {
                if (string.IsNullOrEmpty(titleTextBox.Text))
                {
                    e.Cancel = true;
                    ErrorProvider.SetError(titleTextBox, "Title cannot be empty.");
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        private void EndTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(sender is DateTimePicker endTimePicker)
            {
                if (endTimePicker.Value > MainTimePicker.Value)
                {
                    e.Cancel = true;
                    ErrorProvider.SetError(endTimePicker, "End time cannot be bigger than Start time");
                }
                else
                {
                    e.Cancel= false;
                }
            }
        }
    }
}
