using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Organizer_Project.Interfaces;
using Organizer_Project.User_Controls;
using Organizer_Project.Forms;

namespace Organizer_Project
{
    public partial class OrganizerForm : Form
    {
        private ItemDetailsForm DetailsForm;
        private ItemCreateForm CreateForm;
        private readonly IManagerService<OrganizerItem> ManagerService;

        public OrganizerForm(IManagerService<OrganizerItem> managerService)
        {
            InitializeComponent();
            ManagerService = managerService;
        }

        private void RemoveFromDashboardLayout(object sender, EventArgs e)
        {
            IOrganizerItemControl itemControl = sender as IOrganizerItemControl;
            if (itemControl != null)
            {
                ManagerService.DeleteItem(itemControl.GetItem());
                RenderDashboardLayout();
            }
        }

        private void UpdateDashboardLayout(object sender, EventArgs e)
        {
            IOrganizerItemControl itemControl = sender as IOrganizerItemControl;
            if (itemControl != null)
            {
                ManagerService.UpdateItem(itemControl.GetItem());
                RenderDashboardLayout();
            }
        }

        private void AddToDashboardLayout(object sender, EventArgs e)
        {
            IOrganizerItemControl itemControl = sender as IOrganizerItemControl;
            if (itemControl != null)
            {
                ManagerService.AddItem(itemControl.GetItem());
                RenderDashboardLayout();
            }
        }

        private void OrganizerForm_Load(object sender, EventArgs e)
        {
            RenderDashboardLayout();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (CreateForm != null && !CreateForm.IsDisposed)
            {
                CreateForm.Dispose();
                return;
            }
            CreateForm = new ItemCreateForm(ItemType.Task);
            CreateForm.ItemCreated += AddToDashboardLayout;
            CreateForm.ShowDialog();
            CreateForm.Dispose();
            CreateForm = null;
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            if (CreateForm != null && !CreateForm.IsDisposed)
            {
                CreateForm.Dispose();
                return;
            }
            CreateForm = new ItemCreateForm(ItemType.Event);
            CreateForm.ItemCreated += AddToDashboardLayout;
            CreateForm.ShowDialog();
            CreateForm.Dispose();
            CreateForm = null;
        }

        private void RenderDashboardLayout()
        {
            DashboardTableLayout.SuspendLayout();
            DashboardTableLayout.Controls.Clear();

            foreach (var item in ManagerService.GetItems())
            {
                var control = new OrganizerItemControl(item);
                control.ItemDetailsRequested += ItemDetailsForm_Create;
                DashboardTableLayout.Controls.Add(control);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            }

            DashboardTableLayout.ResumeLayout();
        }
        private void ItemDetailsForm_Create(object sender, EventArgs e)
        {
            OrganizerItemControl itemControl = sender as OrganizerItemControl;
            if (DetailsForm != null && !DetailsForm.IsDisposed)
            {
                DetailsForm.Dispose();
                return;
            }
            if (itemControl != null)
            {
                try
                {
                    var item = itemControl.GetItem();
                    DetailsForm = new ItemDetailsForm(item);
                    DetailsForm.ItemSaved += UpdateDashboardLayout;
                    DetailsForm.ItemDeleted += RemoveFromDashboardLayout;
                    DetailsForm.ShowDialog();
                    DetailsForm.Dispose();
                    DetailsForm = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while opening the item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
