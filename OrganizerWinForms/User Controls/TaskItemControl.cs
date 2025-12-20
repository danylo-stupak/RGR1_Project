using System.Collections.Generic;
using System.Windows.Forms;

namespace Organizer_Project.UserControls
{
    public partial class TaskItemControl : UserControl, Interfaces.IOrganizerItemControl
    {
        public BindingSource ItemSource { get; }
        public int ItemPosition
        {
            get => ItemSource.Position;
            set => ItemSource.Position = value;
        }
        private bool IsEditMode;
        private BindingSource ItemSourceCopy { get; }
        public TaskItemControl(BindingSource source, int position, bool editMode = false)
        {
            InitializeComponent();
            ItemSource = source;        // keep original public
            ItemPosition = position;
            ItemSourceCopy = new BindingSource
            {
                DataSource = new Models.TaskItem(source.DataSource as Models.TaskItem)     // creating a private copy
            };
            IsEditMode = editMode;
        }
        public Interfaces.OrganizerItem GetItem()
        {
            ItemSourceCopy.EndEdit();
            return ItemSourceCopy.DataSource as Models.TaskItem;
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
        private void BindData()
        {
            DataSourceUpdateMode updateMode_1 = DataSourceUpdateMode.OnPropertyChanged;
            DataSourceUpdateMode updateMode_2 = DataSourceUpdateMode.OnValidation;
            // edit layout bindings
            TitleTextBox.DataBindings.Add("Text", ItemSourceCopy, "Title", true, updateMode_2);         // binding copy for free changes
            PriorityComboBox.DataBindings.Add("SelectedValue", ItemSourceCopy, "Priority", true, updateMode_1);
            MainTimePicker.DataBindings.Add("Value", ItemSourceCopy, "Time", true, updateMode_1);
            StatusComboBox.DataBindings.Add("SelectedValue", ItemSourceCopy, "Status", true, updateMode_1);
            GroupTextBox.DataBindings.Add("Text", ItemSourceCopy, "Group", true, updateMode_1);
            NotesRichTextBox.DataBindings.Add("Text", ItemSourceCopy, "Notes", true, updateMode_1);
            // view layout bindings
            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.Never);     // binding original to display only
            PriorityLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.Never);
            MainTimeLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.Never);
            StatusLabel.DataBindings.Add("Text", ItemSource, "Status", true, DataSourceUpdateMode.Never);
            GroupLabel.DataBindings.Add("Text", ItemSource, "Group", true, DataSourceUpdateMode.Never);
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
            var statuses = new List<KeyValuePair<string, Models.TaskStatus>>
            {
                new KeyValuePair<string, Models.TaskStatus>("New", Models.TaskStatus.New),
                new KeyValuePair<string, Models.TaskStatus>("In Progress", Models.TaskStatus.InProgress),
                new KeyValuePair<string, Models.TaskStatus>("Done", Models.TaskStatus.Done),
                new KeyValuePair<string, Models.TaskStatus>("Cancelled", Models.TaskStatus.Cancelled)
            };
            PriorityComboBox.DataSource = priorities;
            PriorityComboBox.DisplayMember = "Key";
            PriorityComboBox.ValueMember = "Value";
            StatusComboBox.DataSource = statuses;
            StatusComboBox.DisplayMember = "Key";
            StatusComboBox.ValueMember = "Value";
        }
        private void TaskControl_Load(object sender, System.EventArgs e)
        {
            ConfigureComboBoxes();
            BindData();
            ToggleMode(IsEditMode);
        }
        private void TitleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ItemSource != null)
            {
                string title = TitleTextBox.Text.Trim();
                if (string.IsNullOrEmpty(title))
                {
                    e.Cancel = true;
                    ErrorProvider.SetError(TitleTextBox, "Title cannot be empty.");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProvider.SetError(TitleTextBox, ""); // Clear error
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
