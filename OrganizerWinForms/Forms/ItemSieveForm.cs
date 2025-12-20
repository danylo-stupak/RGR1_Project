using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class ItemSieveForm : Form
    {
        private readonly UserControls.ItemPropertyControl FilterByTypeControl;
        private readonly UserControls.ItemPropertyControl FilterByTextControl;
        private readonly UserControls.ItemPropertyControl FilterByPriorityControl;
        private readonly UserControls.ItemPropertyControl FilterByStatusControl;
        private readonly UserControls.ItemPropertyControl FilterByTimeControl;
        private readonly UserControls.ItemPropertyControl FilterByEndTimeControl;
        private readonly UserControls.ItemPropertyControl SortByTimeControl;
        private readonly UserControls.ItemPropertyControl SortByEndTimeControl;
        public readonly Models.ItemSieveDTO SieveDTO;
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
        public ItemSieveForm(Models.ItemSieveDTO sieveDTO = null)
        {
            InitializeComponent();
            // retrieve or allocate memoty for data transfer object
            SieveDTO = sieveDTO ?? new Models.ItemSieveDTO();
            // Allocate memory for usercontrols
            FilterByTypeControl = new UserControls.ItemPropertyControl("Type", SieveDTO.FilterByType, System.Enum.GetNames(typeof(Interfaces.ItemType)));
            FilterByTextControl = new UserControls.ItemPropertyControl("Text", SieveDTO.FilterByText);
            FilterByPriorityControl = new UserControls.ItemPropertyControl("Priority", SieveDTO.FilterByPriority, System.Enum.GetNames(typeof(Interfaces.Priority)));
            FilterByTimeControl = new UserControls.ItemPropertyControl("Time", SieveDTO.FilterByTime);
            FilterByEndTimeControl = new UserControls.ItemPropertyControl("EndTime", SieveDTO.FilterByEndTime);
            FilterByStatusControl = new UserControls.ItemPropertyControl("Status", SieveDTO.FilterByStatus, System.Enum.GetNames(typeof(Models.TaskStatus)));
            SortByTimeControl = new UserControls.ItemPropertyControl("Time", SieveDTO.SortByTime, System.Enum.GetNames(typeof(Models.ItemSortOrder)));
            SortByEndTimeControl = new UserControls.ItemPropertyControl("EndTime", SieveDTO.SortByEndTime, System.Enum.GetNames(typeof(Models.ItemSortOrder)));
            // Suspend layout
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
            // Resume all layout
            FilteringTableLayout.ResumeLayout(false);
            FilteringTableLayout.PerformLayout();
            SortingTableLayout.ResumeLayout(false);
            SortingTableLayout.PerformLayout();
            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
        }
        private void FilterByTypeControl_EnabledChanged(object sender, System.EventArgs e)
        {
            MainTableLayout.SuspendLayout();
            FilteringTableLayout.SuspendLayout();
            SortingTableLayout.SuspendLayout();
            if (SieveDTO.FilterByType.IsEnabled && SieveDTO.FilterByType.Value is int item)
            {
                TaskProperties = item is (int)Interfaces.ItemType.Task;
                EventProperties = item is (int)Interfaces.ItemType.Event;
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
        private void FilterItemsForm_Load(object sender, System.EventArgs e)
        {
            TaskProperties = false;
            EventProperties = false;
        }
        private void ApplyButton_Click(object sender, System.EventArgs e)
        {
            SieveDTO.Update();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
