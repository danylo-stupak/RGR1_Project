using System;
using System.Windows.Forms;
using Organizer_Project.Interfaces;
using Organizer_Project.User_Controls;
using Organizer_Project.Forms;

namespace Organizer_Project
{
    public partial class OrganizerForm : Form
    {
        private readonly IManagerService<OrganizerItem> ManagerService;

        public OrganizerForm(IManagerService<OrganizerItem> managerService)
        {
            InitializeComponent();
            ManagerService = managerService;
        }

        private void RemoveFromDashboardLayout(object sender, EventArgs e)
        {
            ItemDetailsForm detailsForm = sender as ItemDetailsForm;
            if (detailsForm != null)
            {
                ManagerService.DeleteItem(detailsForm.GetItem());
            }
        }

        private void UpdateDashboardLayout(object sender, EventArgs e)
        {
            ItemDetailsForm detailsForm = sender as ItemDetailsForm;
            if (detailsForm != null)
            {
                ManagerService.UpdateItem(detailsForm.GetItem());
            }
        }

        private void AddToDashboardLayout(object sender, EventArgs e)
        {
            ItemCreateForm createForm = sender as ItemCreateForm;
            if (createForm != null)
            {
                ManagerService.AddItem(createForm.GetItem());
            }
        }

        private void OrganizerForm_Load(object sender, EventArgs e)
        {
            RenderDashboardLayout();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            using (var CreateForm = new ItemCreateForm(ItemType.Task))
            {
                CreateForm.ItemCreated += AddToDashboardLayout;
                if(CreateForm.ShowDialog() == DialogResult.OK)
                {
                    RenderDashboardLayout();
                }
            }
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            using (var CreateForm = new ItemCreateForm(ItemType.Event))
            {
                CreateForm.ItemCreated += AddToDashboardLayout;
                CreateForm.ShowDialog();
            }
        }

        private void ClearDashboardLayout(bool isHidden)
        {
            if (!isHidden)
            {
                DashboardTableLayout.Hide();
                DashboardTableLayout.SuspendLayout();
            }
            for (Control control = DashboardTableLayout.GetControlFromPosition(0, 1); control != null; control = DashboardTableLayout.GetControlFromPosition(0, 1))
            {
                DashboardTableLayout.Controls.Remove(control);
                control.Dispose();
            }
            DashboardTableLayout.RowStyles.Clear();
            DashboardTableLayout.RowCount = 1; // Reset to 1 to account for header row
            if (!isHidden)
            {
                DashboardTableLayout.ResumeLayout();
                DashboardTableLayout.Show();
            }
        }

        private void RenderDashboardLayout()
        {
            ClearDashboardLayout(false);

            DashboardTableLayout.Hide();
            DashboardTableLayout.SuspendLayout();
            int currentRow = DashboardTableLayout.RowCount - 1;
            foreach (var item in ManagerService.GetItems())
            {
                var control = new OrganizerItemControl(item);
                control.ItemDetailsRequested += ItemDetailsForm_Create;
                DashboardTableLayout.Controls.Add(control, 0, currentRow);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                DashboardTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                //MessageBox.Show("Loaded item: " + item.Title + " row " + DashboardTableLayout.RowStyles.Count + " styled: " + DashboardTableLayout.RowStyles.Count);
                currentRow++;
            }
        }
        private void ItemDetailsForm_Create(object sender, EventArgs e)
        {
            OrganizerItemControl itemControl = sender as OrganizerItemControl;
            if (itemControl != null)
            {
                var item = itemControl.GetItem();
                using (var detailsForm = new ItemDetailsForm(item))
                {
                    try
                    {
                        detailsForm.ItemSaved += UpdateDashboardLayout;
                        detailsForm.ItemDeleted += RemoveFromDashboardLayout;
                        detailsForm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while opening the item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
