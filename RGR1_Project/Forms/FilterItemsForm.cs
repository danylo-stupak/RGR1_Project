using Organizer_Project.Interfaces;
using Organizer_Project.User_Controls;
using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class FilterItemsForm : Form
    {
        private readonly ItemPropertyControl FilterByTypeControl;
        private readonly ItemPropertyControl FilterByTextControl;
        private readonly ItemPropertyControl FilterByPriorityControl;
        private readonly ItemPropertyControl FilterByStatusControl;
        private readonly ItemPropertyControl FilterByTimeControl;
        private readonly ItemPropertyControl FilterByEndTimeControl;

        private readonly ItemPropertyControl SortByTextControl;
        private readonly ItemPropertyControl SortByPriorityControl;
        private readonly ItemPropertyControl SortByStatusControl;
        private readonly ItemPropertyControl SortByTimeControl;
        private readonly ItemPropertyControl SortByEndTimeControl;

        private bool TaskProperties
        {
            set
            {
                FilterByStatusGroup.Enabled = value;
                FilterByStatusGroup.Visible = value;

                SortByStatusGroup.Enabled = value;
                SortByStatusGroup.Visible = value;
            }
        }

        private bool EventProperties
        {
            set
            {
                FilterByEndTimeGroup.Enabled = value;
                FilterByEndTimeGroup.Visible = value;

                SortByEndTimeGroup.Enabled = value;
                SortByEndTimeGroup.Visible = value;
            }
        }
        
        public event EventHandler Applying;
        public FilterItemsForm()
        {
            InitializeComponent();
            FilterByTypeControl = new ItemPropertyControl(PropertyType.Enum, Enum.GetNames(typeof(ItemType)));
            FilterByTextControl = new ItemPropertyControl(PropertyType.Text);
            FilterByPriorityControl = new ItemPropertyControl(PropertyType.Enum, Enum.GetNames(typeof(Priority)));
            FilterByStatusControl = new ItemPropertyControl(PropertyType.Enum, Enum.GetNames(typeof(TaskStatus)));
            FilterByTimeControl = new ItemPropertyControl(PropertyType.Date);
            FilterByEndTimeControl = new ItemPropertyControl(PropertyType.Date);

            SortByTextControl = new ItemPropertyControl(PropertyType.Text);
            SortByPriorityControl = new ItemPropertyControl(PropertyType.Enum, Enum.GetNames(typeof(Priority)));
            SortByStatusControl = new ItemPropertyControl(PropertyType.Enum, Enum.GetNames(typeof(TaskStatus)));
            SortByTimeControl = new ItemPropertyControl(PropertyType.Date);
            SortByEndTimeControl = new ItemPropertyControl(PropertyType.Date);

            // Adding property filter controls to its appropriate GroupBox
            FilterByTypeGroup.Controls.Add(FilterByTypeControl);
            FilterByTypeControl.Dock = DockStyle.Fill;
            FilterByTypeControl.EnabledToggle += FilterByTypeControl_EnabledChanged;

            FilterByTextGroup.Controls.Add(FilterByTextControl);
            FilterByTextControl.Dock = DockStyle.Fill;

            FilterByPriorityGroup.Controls.Add(FilterByPriorityControl);
            FilterByPriorityControl.Dock = DockStyle.Fill;

            FilterByStatusGroup.Controls.Add(FilterByStatusControl);
            FilterByStatusControl.Dock = DockStyle.Fill;

            FilterByTimeGroup.Controls.Add(FilterByTimeControl);
            FilterByTimeControl.Dock = DockStyle.Fill;

            FilterByEndTimeGroup.Controls.Add(FilterByEndTimeControl);
            FilterByEndTimeControl.Dock = DockStyle.Fill;



            // Adding property sorter controls to its appropriate GroupBox
            SortByTextGroup.Controls.Add(SortByTextControl);
            SortByTextControl.Dock = DockStyle.Fill;

            SortByPriorityGroup.Controls.Add(SortByPriorityControl);
            SortByPriorityControl.Dock = DockStyle.Fill;

            SortByStatusGroup.Controls.Add(SortByStatusControl);
            SortByStatusControl.Dock = DockStyle.Fill;

            SortByTimeGroup.Controls.Add(SortByTimeControl);
            SortByTimeControl.Dock = DockStyle.Fill;

            SortByEndTimeGroup.Controls.Add(SortByEndTimeControl);
            SortByEndTimeControl.Dock = DockStyle.Fill;
        }

        private void FilterByTypeControl_EnabledChanged(object sender, EventArgs e)
        {
            if(FilterByTypeControl.Value is ItemType item)
            {
                TaskProperties = item is ItemType.Task;
                EventProperties = item is ItemType.Event;
            }
        }

        private void FilterItemsForm_Load(object sender, EventArgs e)
        {
            TaskProperties = false;
            EventProperties = false;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Applying?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
