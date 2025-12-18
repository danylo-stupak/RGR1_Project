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

        private readonly ItemPropertyControl SortByTimeControl;
        private readonly ItemPropertyControl SortByEndTimeControl;

        public readonly ItemSieveDTO SieveDTO;
        private bool TaskProperties
        {
            set
            {
                FilterByStatusControl.Enabled = value;
                FilterByStatusControl.Visible = value;
            }
        }
        private bool EventProperties
        {
            set
            {
                FilterByEndTimeControl.Enabled = value;
                FilterByEndTimeControl.Visible = value;

                SortByEndTimeControl.Enabled = value;
                SortByEndTimeControl.Visible = value;
            }
        }
        public ItemSieveForm(ItemSieveDTO sieveDTO = null)
        {
            InitializeComponent();
            SieveDTO = sieveDTO ?? new ItemSieveDTO();

            FilterByTypeControl = new ItemPropertyControl("Type", SieveDTO.FilterByType, Enum.GetNames(typeof(ItemType)));
            FilterByTextControl = new ItemPropertyControl("Text", SieveDTO.FilterByText);
            FilterByPriorityControl = new ItemPropertyControl("Priority", SieveDTO.FilterByPriority, Enum.GetNames(typeof(Priority)));
            FilterByTimeControl = new ItemPropertyControl("Time", SieveDTO.FilterByTime);

            FilterByEndTimeControl = new ItemPropertyControl("EndTime", SieveDTO.FilterByEndTime);
            FilterByStatusControl = new ItemPropertyControl("Status", SieveDTO.FilterByStatus, Enum.GetNames(typeof(TaskStatus)));

            SortByTimeControl = new ItemPropertyControl("Time", SieveDTO.SortByTime);
            SortByEndTimeControl = new ItemPropertyControl("EndTime", SieveDTO.SortByEndTime);
            
            MainTableLayout.SuspendLayout();
            FilteringTableLayout.SuspendLayout();
            SortingTableLayout.SuspendLayout();
            // Adding property filter controls to its appropriate GroupBox

            FilteringTableLayout.Controls.Add(FilterByTypeControl);
            //FilterByTypeControl.Dock = DockStyle.Fill;
            FilterByTypeControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FilterByTypeControl.EnabledToggle += FilterByTypeControl_EnabledChanged;

            FilteringTableLayout.Controls.Add(FilterByTextControl);
            //FilterByTextControl.Dock = DockStyle.Fill;
            FilterByTextControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            FilteringTableLayout.Controls.Add(FilterByPriorityControl);
            FilterByPriorityControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            FilteringTableLayout.Controls.Add(FilterByStatusControl);
            FilterByStatusControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            FilteringTableLayout.Controls.Add(FilterByTimeControl);
            FilterByTimeControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            FilteringTableLayout.Controls.Add(FilterByEndTimeControl);
            FilterByEndTimeControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;



            // Adding property sorter controls to its appropriate GroupBox
            SortingTableLayout.Controls.Add(SortByTimeControl);
            SortByTimeControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            SortingTableLayout.Controls.Add(SortByEndTimeControl);
            SortByEndTimeControl.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            FilteringTableLayout.ResumeLayout(false);
            FilteringTableLayout.PerformLayout();
            SortingTableLayout.ResumeLayout(false);
            SortingTableLayout.PerformLayout();
            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
        }


        private void FilterByTypeControl_EnabledChanged(object sender, EventArgs e)
        {
            MainTableLayout.SuspendLayout();
            FilteringTableLayout.SuspendLayout();
            SortingTableLayout.SuspendLayout();
            if (SieveDTO.FilterByType.IsEnabled && SieveDTO.FilterByType.Value is int item)
            {
                TaskProperties = item is (int)ItemType.Task;
                EventProperties = item is (int)ItemType.Event;
            }
            else
            {
                TaskProperties = false;
                EventProperties = false;
            }
            SortingTableLayout.ResumeLayout(false);
            SortingTableLayout.PerformLayout();

            FilteringTableLayout.ResumeLayout(false);
            FilteringTableLayout.PerformLayout();

            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
        }

        private void FilterItemsForm_Load(object sender, EventArgs e)
        {
            TaskProperties = false;
            EventProperties = false;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SieveDTO.Update();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
