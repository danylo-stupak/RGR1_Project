using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class TaskItemControl : UserControl, IOrganizerItemControl
    {
        private BindingSource TaskBindingSource;
        private bool IsEditMode = true;
        public TaskItemControl(TaskItem taskItem)
        {
            InitializeComponent();
            TaskBindingSource = new BindingSource();
            TaskBindingSource.DataSource = taskItem;
            
        }

        public OrganizerItem GetItem()
        {
            return (OrganizerItem)TaskBindingSource.DataSource;
        }
        public void ToggleEditMode(bool isEditMode)
        {
            if(isEditMode == IsEditMode)
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
            StatusComboBox.Enabled = isEditMode;
            NotesRichTextBox.ReadOnly = !isEditMode;
        }

        private void ToggleControlsCursor(bool isEditMode)
        {
            Cursor currentCursor = isEditMode ? Cursors.IBeam : Cursors.Default;
            TitleTextBox.Cursor = currentCursor;
            PriorityComboBox.Cursor = currentCursor;
            MainTimePicker.Cursor = currentCursor;
            StatusComboBox.Cursor = currentCursor;
            NotesRichTextBox.Cursor = currentCursor;
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {
            if (TaskBindingSource != null)
            {
                PriorityComboBox.Items.AddRange(Enum.GetNames(typeof(Priority)));
                StatusComboBox.Items.AddRange(Enum.GetNames(typeof(TaskStatus)));
                TitleTextBox.DataBindings.Add("Text", TaskBindingSource, "Title", true, DataSourceUpdateMode.OnValidation);
                PriorityComboBox.DataBindings.Add("SelectedIndex", TaskBindingSource, "Priority", true, DataSourceUpdateMode.OnValidation);
                MainTimePicker.DataBindings.Add("Value", TaskBindingSource, "Time", true, DataSourceUpdateMode.OnValidation);
                StatusComboBox.DataBindings.Add("SelectedIndex", TaskBindingSource, "Status", true, DataSourceUpdateMode.OnValidation);
                NotesRichTextBox.DataBindings.Add("Text", TaskBindingSource, "Notes", true, DataSourceUpdateMode.OnValidation);
            }

        }
    }
}
