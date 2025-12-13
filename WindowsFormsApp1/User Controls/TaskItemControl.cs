using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class TaskItemControl : UserControl, IOrganizerItemControl
    {
        private BindingSource TaskBindingSource;
        private bool IsEditMode;
        public TaskItemControl(TaskItem taskItem, bool editMode = false)
        {
            var taskItemCopy = new TaskItem(taskItem); // Create a copy to avoid modifying the original until saved
            InitializeComponent();
            TaskBindingSource = new BindingSource
            {
                DataSource = taskItemCopy
            };
            IsEditMode = editMode;
        }

        public OrganizerItem GetItem()
        {
            TaskBindingSource.EndEdit();
            return (TaskItem)TaskBindingSource.DataSource;
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
            TitleTextBox.DataBindings.Add("Text", TaskBindingSource, "Title", true, DataSourceUpdateMode.OnValidation);
            PriorityComboBox.DataBindings.Add("SelectedValue", TaskBindingSource, "Priority", true, DataSourceUpdateMode.OnPropertyChanged);
            MainTimePicker.DataBindings.Add("Value", TaskBindingSource, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            StatusComboBox.DataBindings.Add("SelectedValue", TaskBindingSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged);
            GroupTextBox.DataBindings.Add("Text", TaskBindingSource, "Group", true, DataSourceUpdateMode.OnValidation);
            NotesRichTextBox.DataBindings.Add("Text", TaskBindingSource, "Notes", true, DataSourceUpdateMode.OnPropertyChanged);

            TitleLabel.DataBindings.Add("Text", TaskBindingSource, "Title", true, DataSourceUpdateMode.Never);
            PriorityLabel.DataBindings.Add("Text", TaskBindingSource, "Priority", true, DataSourceUpdateMode.Never);
            MainTimeLabel.DataBindings.Add("Text", TaskBindingSource, "Time", true, DataSourceUpdateMode.Never);
            StatusLabel.DataBindings.Add("Text", TaskBindingSource, "Status", true, DataSourceUpdateMode.Never);
            GroupLabel.DataBindings.Add("Text", TaskBindingSource, "Group", true, DataSourceUpdateMode.Never);
            NotesLabel.DataBindings.Add("Text", TaskBindingSource, "Notes", true, DataSourceUpdateMode.Never);
            
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
            if (TaskBindingSource != null)
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
