using Organizer_Project.Factories;
using Organizer_Project.Forms;
using Organizer_Project.Interfaces;
using System;
using System.Windows.Forms;

namespace Organizer_Project
{
    public partial class ItemMainForm : Form
    {
        private readonly IManagerService<OrganizerItem> ManagerService;
        public ItemMainForm(IManagerService<OrganizerItem> managerService)
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
            ManagerService.BindingSource.ResetBindings(false);
            for (int i = 0; i < ManagerService.BindingSource.Count; i++)
            {
                var control = DemoControlFactory.CreateDemoControl(ManagerService.BindingSource, i);
                control.ItemDetailsRequested += ItemDetailsForm_Create;
                control.ItemEdited += UpdateDashboardLayout;
                control.ItemDeleted += RemoveFromDashboardLayout;
                if (control is Control winControl)
                {
                    winControl.AutoSize = true;
                    DashboardFlowLayout.Controls.Add(winControl);
                }
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
            if (sender is IOrganizerItemDemoControl itemControl)
            {
                try
                {
                    itemControl.Action();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ItemDetailsForm_Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RemoveFromDashboardLayout(object sender, EventArgs e)
        {
            if (sender is IOrganizerItemDemoControl itemControl)
            {
                try
                {
                    ManagerService.DeleteItem(itemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RemoveFromDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateDashboardLayout(object sender, EventArgs e)
        {
            if (sender is ItemDetailsForm detailsForm)
            {
                try
                {
                    ManagerService.UpdateItem(detailsForm.ItemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "UpdateDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                try
                {
                    ManagerService.AddItem(createForm.ItemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AddToDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new ArgumentException("Error: Unable to update item in dashboard layout.");
            }
        }
        private void FilterItemsForm_Applying(object sender, EventArgs e)
        {
            if (sender is ItemSieveForm filterForm)
            {
                MessageBox.Show("Success!", "Apply Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
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
                    CreateForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AddTaskButton_Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CreateForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AddEventButton_Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void StatsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ManagerService.GetStatistics(), "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            using(ItemSieveForm filterItemsForm = new ItemSieveForm())
            {
                filterItemsForm.Applying += FilterItemsForm_Applying;
                if(filterItemsForm.ShowDialog() == DialogResult.OK)
                {
                    RerenderDashboardLayout();
                }
            }
        }
    }
}
