using System.Windows.Forms;
using Organizer_Project.Models;
using Organizer_Project.Interfaces;

namespace Organizer_Project.User_Controls
{
    public partial class EventItemControl : UserControl, IOrganizerItemControl
    {
        private BindingSource EventBindingSource;
        private bool IsEditMode = true;
        public EventItemControl(EventItem eventItem)
        {
            InitializeComponent();
            EventBindingSource = new BindingSource();
            EventBindingSource.DataSource = eventItem;
        }
        public OrganizerItem GetItem()
        {
            return (OrganizerItem)EventBindingSource.DataSource;
        }

        public void ToggleEditMode(bool isEditMode)
        {
            if (isEditMode == IsEditMode)
                return;
            else
            {
                IsEditMode = isEditMode;
                ToggleControlsEnabled(isEditMode);
                ToggleControlsCursor(isEditMode);

            }
        }

        private void ToggleControlsEnabled(bool isEditMode)
        {
            TitleTextBox.ReadOnly = !isEditMode;
            PriorityComboBox.Enabled = isEditMode;
            MainTimePicker.Enabled = isEditMode;
            EndTimePicker.Enabled = isEditMode;
            AllDayCheckBox.Enabled = isEditMode;
            NotesRichTextBox.ReadOnly = !isEditMode;
        }

        private void ToggleControlsCursor(bool isEditMode)
        {
            Cursor currentCursor = isEditMode ? Cursors.IBeam : Cursors.Default;
            TitleTextBox.Cursor = currentCursor;
            PriorityComboBox.Cursor = currentCursor;
            MainTimePicker.Cursor = currentCursor;
            EndTimePicker.Cursor = currentCursor;
            AllDayCheckBox.Cursor = currentCursor;
            NotesRichTextBox.Cursor = currentCursor;
        }

        private void ConfigureDateTimePickers()
        {
            string format = AllDayCheckBox.Checked ? "ddd, dd MMM" : "ddd, dd MMM - HH:mm";
            MainTimePicker.CustomFormat = format;
            EndTimePicker.CustomFormat = format;
        }

        private void EventControl_Load(object sender, System.EventArgs e)
        {
            if (EventBindingSource != null) {
                PriorityComboBox.Items.AddRange(System.Enum.GetNames(typeof(Priority)));
                ConfigureDateTimePickers();

                TitleTextBox.DataBindings.Add("Text", EventBindingSource, "Title", true, DataSourceUpdateMode.OnValidation);
                PriorityComboBox.DataBindings.Add("SelectedIndex", EventBindingSource, "Priority", true, DataSourceUpdateMode.OnValidation);
                MainTimePicker.DataBindings.Add("Value", EventBindingSource, "Time", true, DataSourceUpdateMode.OnValidation);
                EndTimePicker.DataBindings.Add("Value", EventBindingSource, "EndTime", true, DataSourceUpdateMode.OnValidation);
                AllDayCheckBox.DataBindings.Add("Checked", EventBindingSource, "IsAllDay", true, DataSourceUpdateMode.OnValidation);
                NotesRichTextBox.DataBindings.Add("Text", EventBindingSource, "Notes", true, DataSourceUpdateMode.OnValidation);
            }
        }

        private void AllDayCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            ConfigureDateTimePickers();
        }
    }
}
