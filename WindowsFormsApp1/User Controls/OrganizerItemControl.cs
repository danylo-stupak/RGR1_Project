using Organizer_Project.Forms;
using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class OrganizerItemControl : UserControl, IOrganizerItemControl
    {
        private BindingSource ItemSource;
        public event EventHandler ItemDetailsRequested;
        public event EventHandler ItemEdited;
        public event EventHandler ItemDeleted;
        public OrganizerItemControl(OrganizerItem item)
        {
            InitializeComponent();
            ItemSource = new BindingSource();
            ItemSource.DataSource = item;
        }
        private void OrganizerItemControl_Load(object sender, System.EventArgs e)
        {
            // bind the item property to the control
            TypeLabel.DataBindings.Add("Text", ItemSource, "Type", true, DataSourceUpdateMode.OnPropertyChanged);
            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            PriorityLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.OnPropertyChanged);
            MainTimeLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            LoadItemControl((OrganizerItem)ItemSource.Current);
        }

        public void ToggleEditMode(bool isEditMode)
        {
            // This control is read-only, so no edit mode functionality is implemented.
        }

        public OrganizerItem GetItem()
        {
            return (OrganizerItem)ItemSource.Current;
        }

        private void LoadItemControl(OrganizerItem item)
        {
            switch (item.Type)
            {
                case ItemType.Task:
                    LoadItemControl((TaskItem)item);
                    break;
                case ItemType.Event:
                    LoadItemControl((EventItem)item);
                    break;
            }
        }
        private void LoadItemControl(TaskItem taskItem)
        {
            // Show Task-specific controls
            StatusLabel.Visible = true;
            StatusLabel.DataBindings.Add("Text", ItemSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

            // Hide Event-specific controls
            EndTimeLabel.Visible = false;
            EndTimeLabel.DataBindings.Clear();
        }

        private void LoadItemControl(EventItem eventItem)
        {
            // Hide Task-specific controls
            StatusLabel.Visible = false;
            StatusLabel.DataBindings.Clear();

            // Show Event-specific controls
            EndTimeLabel.Visible = true;
            EndTimeLabel.DataBindings.Add("Text", ItemSource, "EndTime", true, DataSourceUpdateMode.OnPropertyChanged);
            string dateFormat = eventItem.IsAllDay ? "ddd, dd MMM" : "ddd, dd MMM     hh:mm";
            MainTimeLabel.Text = eventItem.Time.ToString(dateFormat);
            EndTimeLabel.Text = eventItem.EndTime.ToString(dateFormat);
            
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ItemDetailsRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}

