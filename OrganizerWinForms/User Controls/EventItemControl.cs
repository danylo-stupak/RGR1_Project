using System.Collections.Generic;
using System.Windows.Forms;

namespace Organizer_Project.UserControls
{
    public partial class EventItemControl : UserControl, Interfaces.IOrganizerItemControl
    {
        public BindingSource ItemSource { get; }
        public int ItemPosition
        {
            get => ItemSource.Position;
            set => ItemSource.Position = value;
        }
        private bool IsEditMode;
        private BindingSource ItemSourceCopy { get; }
        public EventItemControl(BindingSource source, int position, bool editMode = false)
        {
            InitializeComponent();
            ItemSource = source;        // keep original public
            ItemPosition = position;
            ItemSourceCopy = new BindingSource();
            ItemSourceCopy.DataSource = new Models.EventItem(source.DataSource as Models.EventItem);     // create a private copy
            IsEditMode = editMode;
        }
        public Interfaces.OrganizerItem GetItem()
        {
            ItemSourceCopy.EndEdit();
            return ItemSourceCopy.DataSource as Models.EventItem;
        }
        public void ToggleMode(bool isEditMode)
        {
            IsEditMode = isEditMode;
            ToggleControlsEnabled();
        }
        private void ToggleControlsEnabled()
        {
            // stop layout logic
            MainFlowLayout.SuspendLayout();
            // Togge edit mode
            EditModeLayout.Visible = IsEditMode;
            EditModeLayout.Enabled = IsEditMode;
            // toogle view mode
            ViewModeLayout.Visible = !IsEditMode;
            ViewModeLayout.Enabled = !IsEditMode;
            // remove all edit and view layouts
            MainFlowLayout.Controls.Clear();
            MainFlowLayout.Controls.Add(IsEditMode ? EditModeLayout : ViewModeLayout);
            // resume layout logic
            MainFlowLayout.ResumeLayout(false);
            MainFlowLayout.PerformLayout();
        }
        private void ConfigureDateTimePickers()
        {
            string format = AllDayCheckBox_Edit.Checked ? "ddd, dd/MM" : "ddd, dd/MM/yy - HH:mm";
            MainTimePicker.CustomFormat = format;
            EndTimePicker.CustomFormat = format;
        }
        private void BindData()
        {
            DataSourceUpdateMode updateMode_1 = DataSourceUpdateMode.OnPropertyChanged;
            DataSourceUpdateMode updateMode_2 = DataSourceUpdateMode.OnValidation;
            // edit layout bindings
            TitleTextBox.DataBindings.Add("Text", ItemSourceCopy, "Title", true, updateMode_2);      // binding copy for free changes
            PriorityComboBox.DataBindings.Add("SelectedValue", ItemSourceCopy, "Priority", true, updateMode_1);
            MainTimePicker.DataBindings.Add("Value", ItemSourceCopy, "Time", true, updateMode_1);
            EndTimePicker.DataBindings.Add("Value", ItemSourceCopy, "EndTime", true, updateMode_2);
            AllDayCheckBox_Edit.DataBindings.Add("Checked", ItemSourceCopy, "IsAllDay", true, updateMode_1);
            NotesRichTextBox.DataBindings.Add("Text", ItemSourceCopy, "Notes", true, updateMode_1);
            // view layout bindings
            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.Never);  // binding original to display only
            PriorityLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.Never);
            MainTimeLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.Never);
            EndTimeLabel.DataBindings.Add("Text", ItemSource, "EndTime", true, DataSourceUpdateMode.Never);
            AllDayCheckBox_View.DataBindings.Add("Checked", ItemSource, "IsAllDay", true, DataSourceUpdateMode.Never);
            NotesLabel.DataBindings.Add("Text", ItemSource, "Notes", true, DataSourceUpdateMode.Never);
        }
        private void ConfigureComboBoxes()
        {
            var priorities = new List<KeyValuePair<string, Interfaces.Priority>>
            {
                new KeyValuePair<string, Interfaces.Priority>("Low", Interfaces.Priority.Low),
                new KeyValuePair<string, Interfaces.Priority>("Medium", Interfaces.Priority.Medium),
                new KeyValuePair<string, Interfaces.Priority>("High", Interfaces.Priority.High)
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
            if (ItemSource != null)
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
                        ErrorProvider.SetError(titleTextBox, ""); // Clear error
                    }
                }
            }
            else
            {
                e.Cancel = true;
                throw new System.InvalidOperationException("TaskBindingSource is null.");
            }
        }
        private void EndTimePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ItemSource != null)
            {
                if (sender is DateTimePicker endTimePicker)
                {
                    if (endTimePicker.Value <= MainTimePicker.Value)
                    {
                        e.Cancel = true;
                        ErrorProvider.SetError(endTimePicker, "End time cannot be smaller than Start time");
                    }
                    else
                    {
                        e.Cancel= false;
                        ErrorProvider.SetError(endTimePicker, ""); // Clear error
                    }
                }
            }
            else
            {
                e.Cancel = true;
                throw new System.InvalidOperationException("TaskBindingSource is null.");
            }
        }
    }
}
