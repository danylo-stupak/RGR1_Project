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
            
            //MainTableLayout.SuspendLayout();
            // Adding property filter controls to its appropriate GroupBox
            FilterByTypeGroup.Controls.Add(FilterByTypeControl);
            FilterByTypeControl.Dock = DockStyle.Fill;
            FilterByTypeControl.EnabledToggle += FilterByTypeControl_EnabledChanged;

            FilterByTextGroup.Controls.Add(FilterByTextControl);
            //FilterByTextControl.Dock = DockStyle.Fill;

            FilterByPriorityGroup.Controls.Add(FilterByPriorityControl);
            //FilterByPriorityControl.Dock = DockStyle.Fill;

            FilterByStatusGroup.Controls.Add(FilterByStatusControl);
            //FilterByStatusControl.Dock = DockStyle.Fill;

            FilterByTimeGroup.Controls.Add(FilterByTimeControl);
            //FilterByTimeControl.Dock = DockStyle.Fill;

            FilterByEndTimeGroup.Controls.Add(FilterByEndTimeControl);
            //FilterByEndTimeControl.Dock = DockStyle.Fill;



            // Adding property sorter controls to its appropriate GroupBox
            SortByTextGroup.SuspendLayout();
            SortByPriorityGroup.SuspendLayout();
            SortByStatusGroup.SuspendLayout();
            SortByTimeGroup.SuspendLayout();
            SortByEndTimeGroup.SuspendLayout();


            SortByTextGroup.Controls.Add(SortByTextControl);
            //SortByTextControl.Dock = DockStyle.Fill;
            //SortByTextControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;

            SortByPriorityGroup.Controls.Add(SortByPriorityControl);
            //SortByPriorityControl.Dock = DockStyle.Fill;
            //SortByPriorityControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;

            SortByStatusGroup.Controls.Add(SortByStatusControl);
            //SortByStatusControl.Dock = DockStyle.Fill;
            //SortByStatusControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;            

            SortByTimeGroup.Controls.Add(SortByTimeControl);
            //SortByTimeControl.Dock = DockStyle.Fill;
            //SortByTimeControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;

            SortByEndTimeGroup.Controls.Add(SortByEndTimeControl);
            //SortByEndTimeControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;

            SortByTextGroup.ResumeLayout(false);
            SortByTextGroup.PerformLayout();
            SortByPriorityGroup.ResumeLayout(false);
            SortByPriorityGroup.PerformLayout();
            SortByStatusGroup.ResumeLayout(false);
            SortByStatusGroup.PerformLayout();
            SortByTimeGroup.ResumeLayout(false);
            SortByTimeGroup.PerformLayout();
            SortByEndTimeGroup.ResumeLayout(false);
            SortByEndTimeGroup.PerformLayout();

            MainTableLayout.PerformLayout();
        }

        private void FilterByTypeControl_EnabledChanged(object sender, EventArgs e)
        {
            if(FilterByTypeControl.Value is int item)
            {
                TaskProperties = item is (int)ItemType.Task;
                EventProperties = item is (int)ItemType.Event;
            }
        }

        private void FilterItemsForm_Load(object sender, EventArgs e)
        {
            //TaskProperties = false;
            //EventProperties = false;
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
