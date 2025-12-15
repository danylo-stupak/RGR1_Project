using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class TaskItemControl : UserControl, IOrganizerItemControl
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
            ItemSourceCopy = new BindingSource();
            ItemSourceCopy.DataSource = new TaskItem(source.DataSource as TaskItem);     // creating a private copy
            IsEditMode = editMode;
        }
        public OrganizerItem GetItem()
        {
            ItemSourceCopy.EndEdit();
            return ItemSourceCopy.DataSource as TaskItem;
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
        private void BindData()
        {
            DataSourceUpdateMode updateMode_1 = DataSourceUpdateMode.OnPropertyChanged;
            DataSourceUpdateMode updateMode_2 = DataSourceUpdateMode.OnValidation;
            TitleTextBox.DataBindings.Add("Text", ItemSourceCopy, "Title", true, updateMode_2);         // binding copy for free changes
            PriorityComboBox.DataBindings.Add("SelectedValue", ItemSourceCopy, "Priority", true, updateMode_1);
            MainTimePicker.DataBindings.Add("Value", ItemSourceCopy, "Time", true, updateMode_1);
            StatusComboBox.DataBindings.Add("SelectedValue", ItemSourceCopy, "Status", true, updateMode_1);
            GroupTextBox.DataBindings.Add("Text", ItemSourceCopy, "Group", true, updateMode_1);
            NotesRichTextBox.DataBindings.Add("Text", ItemSourceCopy, "Notes", true, updateMode_1);

            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.Never);     // binding original to display only
            PriorityLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.Never);
            MainTimeLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.Never);
            StatusLabel.DataBindings.Add("Text", ItemSource, "Status", true, DataSourceUpdateMode.Never);
            GroupLabel.DataBindings.Add("Text", ItemSource, "Group", true, DataSourceUpdateMode.Never);
            NotesLabel.DataBindings.Add("Text", ItemSource, "Notes", true, DataSourceUpdateMode.Never);
            
        }
        private void ConfigureComboBoxes()
        {
            var priorities = new List<KeyValuePair<string, Priority>>
            {
                new KeyValuePair<string, Priority>("Low", Priority.Low),
                new KeyValuePair<string, Priority>("Medium", Priority.Medium),
                new KeyValuePair<string, Priority>("High", Priority.High)
            };
            var statuses = new List<KeyValuePair<string, TaskStatus>>
            {
                new KeyValuePair<string, TaskStatus>("New", TaskStatus.New),
                new KeyValuePair<string, TaskStatus>("In Progress", TaskStatus.InProgress),
                new KeyValuePair<string, TaskStatus>("Done", TaskStatus.Done),
                new KeyValuePair<string, TaskStatus>("Cancelled", TaskStatus.Cancelled)
            };

            PriorityComboBox.DataSource = priorities;
            PriorityComboBox.DisplayMember = "Key";
            PriorityComboBox.ValueMember = "Value";

            StatusComboBox.DataSource = statuses;
            StatusComboBox.DisplayMember = "Key";
            StatusComboBox.ValueMember = "Value";
        }
        private void TaskControl_Load(object sender, EventArgs e)
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
                }
            }
            else
            {
                e.Cancel = true;
                throw new InvalidOperationException("TaskBindingSource is null.");
            }
        }
    }
}
