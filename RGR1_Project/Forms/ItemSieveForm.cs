using Organizer_Project.Interfaces;
using Organizer_Project.User_Controls;
using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class ItemSieveForm : Form
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

        private readonly ItemSieveDTO SieveDTO;
        private bool TaskProperties
        {
            set
            {
                MainTableLayout.SuspendLayout();
                FilterByStatusGroup.Enabled = value;
                FilterByStatusGroup.Visible = value;

                SortByStatusGroup.Enabled = value;
                SortByStatusGroup.Visible = value;

                MainTableLayout.ResumeLayout(false);
                MainTableLayout.PerformLayout();
            }
        }

        private bool EventProperties
        {
            set
            {
                MainTableLayout.SuspendLayout();
                FilterByEndTimeGroup.Enabled = value;
                FilterByEndTimeGroup.Visible = value;

                SortByEndTimeGroup.Enabled = value;
                SortByEndTimeGroup.Visible = value;

                MainTableLayout.ResumeLayout(false);
                MainTableLayout.PerformLayout();
            }
        }
        
        public event EventHandler Applying;
        public ItemSieveForm()
        {
            InitializeComponent();
            SieveDTO = new ItemSieveDTO();
            FilterByTypeControl = new ItemPropertyControl(SieveDTO.FilterByType, Enum.GetNames(typeof(ItemType)));
            FilterByTextControl = new ItemPropertyControl(SieveDTO.FilterByText);
            FilterByPriorityControl = new ItemPropertyControl(SieveDTO.FilterByPriority, Enum.GetNames(typeof(Priority)));
            FilterByStatusControl = new ItemPropertyControl(SieveDTO.FilterByStatus, Enum.GetNames(typeof(TaskStatus)));
            FilterByTimeControl = new ItemPropertyControl(SieveDTO.FilterByTime);
            FilterByEndTimeControl = new ItemPropertyControl(SieveDTO.FilterByEndTime);

            SortByTextControl = new ItemPropertyControl(SieveDTO.SortByText);
            SortByPriorityControl = new ItemPropertyControl(SieveDTO.SortByPriority, Enum.GetNames(typeof(Priority)));
            SortByStatusControl = new ItemPropertyControl(SieveDTO.SortByStatus, Enum.GetNames(typeof(TaskStatus)));
            SortByTimeControl = new ItemPropertyControl(SieveDTO.SortByTime);
            SortByEndTimeControl = new ItemPropertyControl(SieveDTO.SortByEndTime);

            MainTableLayout.SuspendLayout();
            // Adding property filter controls to its appropriate GroupBox
            FilterByTextGroup.SuspendLayout();
            FilterByPriorityGroup.SuspendLayout();
            FilterByStatusGroup.SuspendLayout();
            FilterByTimeGroup.SuspendLayout();
            FilterByEndTimeGroup.SuspendLayout();
            
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
            SortByTextGroup.SuspendLayout();
            SortByPriorityGroup.SuspendLayout();
            SortByStatusGroup.SuspendLayout();
            SortByTimeGroup.SuspendLayout();
            SortByEndTimeGroup.SuspendLayout();


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

            FilterByTextGroup.ResumeLayout(false);
            FilterByTextGroup.PerformLayout();
            FilterByPriorityGroup.ResumeLayout(false);
            FilterByPriorityGroup.PerformLayout();
            FilterByStatusGroup.ResumeLayout(false);
            FilterByStatusGroup.PerformLayout();
            FilterByTimeGroup.ResumeLayout(false);
            FilterByTimeGroup.PerformLayout();
            FilterByEndTimeGroup.ResumeLayout(false);
            FilterByEndTimeGroup.PerformLayout();

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

            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
        }


        private void FilterByTypeControl_EnabledChanged(object sender, EventArgs e)
        {
            if (SieveDTO.FilterByType.Value is int item)
            {
                TaskProperties = item is (int)ItemType.Task;
                EventProperties = item is (int)ItemType.Event;
            }
            else
            {
                TaskProperties = false;
                EventProperties = false;
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
