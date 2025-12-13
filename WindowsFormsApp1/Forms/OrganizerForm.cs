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
        private void ClearDashboardLayout()
        {
            DashboardFlowLayout.Hide();
            DashboardFlowLayout.SuspendLayout();

            for(var control = DashboardFlowLayout.Controls.Count - 1; control >= 0; control--)
            {
                var itemControl = DashboardFlowLayout.Controls[control];
                DashboardFlowLayout.Controls.RemoveAt(control);
                itemControl.Dispose();
            }
            DashboardFlowLayout.ResumeLayout();
            DashboardFlowLayout.Show();
        }
        private void RenderDashboardLayout()
        {
            DashboardFlowLayout.Hide();
            DashboardFlowLayout.SuspendLayout();

            foreach (var item in ManagerService.GetItems())
            {
                var control = new OrganizerItemControl(item);
                control.ItemDetailsRequested += ItemDetailsForm_Create;
                DashboardFlowLayout.Controls.Add(control);
                control.AutoSize = true;
            }
            DashboardFlowLayout.ResumeLayout();
            DashboardFlowLayout.Show();
        }

        private void RerenderDashboardLayout()
        {
            ClearDashboardLayout();
            RenderDashboardLayout();
        }
        private void ItemDetailsForm_Create(object sender, EventArgs e)
        {
            if (sender is OrganizerItemControl itemControl)
            {
                using (var detailsForm = new ItemDetailsForm(itemControl.GetItem()))
                {
                    try
                    {
                        detailsForm.ItemSaved += UpdateDashboardLayout;
                        detailsForm.ItemDeleted += RemoveFromDashboardLayout;
                        if(detailsForm.ShowDialog() == DialogResult.OK)
                        {
                            RerenderDashboardLayout();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while opening the item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemoveFromDashboardLayout(object sender, EventArgs e)
        {
            if (sender is ItemDetailsForm detailsForm)
            {
                ManagerService.DeleteItem(detailsForm.GetItem());
            }
            else
            {
                throw new ArgumentException("Error: Unable to remove item from dashboard layout.");
            }
        }
        private void UpdateDashboardLayout(object sender, EventArgs e)
        {
            if (sender is ItemDetailsForm detailsForm)
            {
                ManagerService.UpdateItem(detailsForm.GetItem());
            }
            else
            {
                throw new ArgumentException("Error: Unable to update item in dashboard layout.");
            }
        }
        private void AddToDashboardLayout(object sender, EventArgs e)
        {
            if (sender is ItemCreateForm createForm)
            {
                ManagerService.AddItem(createForm.GetItem());
            }
            else
            {
                throw new ArgumentException("Error: Unable to add item to dashboard layout.");
            }
        }
        private void OrganizerForm_Load(object sender, EventArgs e)
        {
            RerenderDashboardLayout();
        }
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            using (var CreateForm = new ItemCreateForm(ItemType.Task))
            {
                try
                {
                    CreateForm.ItemCreated += AddToDashboardLayout;
                    if (CreateForm.ShowDialog() == DialogResult.OK)
                    {
                        RerenderDashboardLayout();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            using (var CreateForm = new ItemCreateForm(ItemType.Event))
            {
                try
                {
                    CreateForm.ItemCreated += AddToDashboardLayout;
                    if (CreateForm.ShowDialog() == DialogResult.OK)
                    {
                        RerenderDashboardLayout();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
