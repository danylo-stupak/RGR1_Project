using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class TaskItemControl : UserControl, IOrganizerItemControl
    {
        private BindingSource TaskBindingSource;
        private TaskItem TaskItem { get; set; } // The copy of the TaskItem being edited
        private bool IsEditMode;
        public TaskItemControl(TaskItem taskItem, bool editMode = false)
        {
            TaskItem = taskItem;
            InitializeComponent();
            TaskBindingSource = new BindingSource
            {
                DataSource = TaskItem
            };
            IsEditMode = editMode;
        }

        public OrganizerItem GetItem()
        {
            return TaskItem;
        }
        public void ToggleEditMode(bool isEditMode)
        {
            IsEditMode = isEditMode;
            ToggleControlsEnabled();
        }

        private void ToggleControlsEnabled()
        {
            TitleTextBox.Enabled = IsEditMode;
            PriorityComboBox.Enabled = IsEditMode;
            MainTimePicker.Enabled = IsEditMode;
            StatusComboBox.Enabled = IsEditMode;
            NotesRichTextBox.Enabled = IsEditMode;
                
            Cursor currentCursor = IsEditMode ? Cursors.IBeam : Cursors.Default;
            TitleTextBox.Cursor = currentCursor;
            NotesRichTextBox.Cursor = currentCursor;
        }

        private void BindData()
        {
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnValidation;
            if (TaskBindingSource != null)
            {
                TitleTextBox.DataBindings.Add("Text", TaskBindingSource, "Title", true, DataSourceUpdateMode.OnValidation);
                PriorityComboBox.DataBindings.Add("SelectedIndex", TaskBindingSource, "Priority", true, updateMode);
                MainTimePicker.DataBindings.Add("Value", TaskBindingSource, "Time", true, updateMode);
                StatusComboBox.DataBindings.Add("SelectedIndex", TaskBindingSource, "Status", true, updateMode);
                NotesRichTextBox.DataBindings.Add("Text", TaskBindingSource, "Notes", true, updateMode);
            }
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {
            PriorityComboBox.Items.AddRange(Enum.GetNames(typeof(Priority)));
            StatusComboBox.Items.AddRange(Enum.GetNames(typeof(TaskStatus)));
            ToggleEditMode(IsEditMode);
            BindData();
        }

        private void TitleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TaskBindingSource != null)
            {
                string title = TitleTextBox.Text.Trim();
                if (string.IsNullOrEmpty(title))
                {
                    e.Cancel = true;
                    throw new InvalidOperationException("Title cannot be empty.");
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
