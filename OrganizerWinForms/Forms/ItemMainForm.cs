using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class ItemMainForm : Form
    {
        private readonly Interfaces.IManagerService<Interfaces.OrganizerItem> ManagerService;
        private Models.ItemSieveDTO SieveDTO = null;
        public ItemMainForm(Interfaces.IManagerService<Interfaces.OrganizerItem> managerService)
        {
            InitializeComponent();
            ManagerService = managerService;
        }
        private void ClearDashboardLayout()
        {
            for(var control = DashboardFlowLayout.Controls.Count - 1; control >= 0; control--)
            {
                var itemControl = DashboardFlowLayout.Controls[control];
                DashboardFlowLayout.Controls.RemoveAt(control);
                if(!(itemControl is Label))
                {
                    itemControl.Dispose();
                }
            }
        }
        private void RenderDashboardLayout()
        {
            int bindCount = ManagerService.BindingSource.Count;
            ManagerService.BindingSource.ResetBindings(false);
            for (int i = 0; i < bindCount; i++)
            {
                var control = Factories.DemoControlFactory.CreateDemoControl(ManagerService.BindingSource, i);
                control.ItemDetailsRequested += ItemDetailsForm_Create;
                control.ItemEdited += UpdateDashboardLayout;
                control.ItemDeleted += RemoveFromDashboardLayout;
                if (control is Control winControl)
                {
                    winControl.AutoSize = true;
                    DashboardFlowLayout.Controls.Add(winControl);
                }
            }
            if(bindCount == 0)
            {
                DashboardFlowLayout.Controls.Add(EmplyListLabel);
            }
        }
        private void RerenderDashboardLayout()
        {
            MainTableLayout.SuspendLayout();
            DashboardFlowLayout.SuspendLayout();
            ClearDashboardLayout();
            RenderDashboardLayout();
            DashboardFlowLayout.ResumeLayout(false);
            DashboardFlowLayout.PerformLayout();
            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
        }
        private void ItemDetailsForm_Create(object sender, System.EventArgs e)
        {
            if (sender is Interfaces.IOrganizerItemDemoControl itemControl)
            {
                try
                {
                    itemControl.Action();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "ItemDetailsForm_Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RemoveFromDashboardLayout(object sender, System.EventArgs e)
        {
            if (sender is Interfaces.IOrganizerItemDemoControl itemControl)
            {
                try
                {
                    ManagerService.DeleteItem(itemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "RemoveFromDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateDashboardLayout(object sender, System.EventArgs e)
        {
            if (sender is Forms.ItemDetailsForm detailsForm)
            {
                try
                {
                    ManagerService.UpdateItem(detailsForm.ItemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "UpdateDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new System.ArgumentException("Error: Unable to update item in dashboard layout.");
            }
        }
        private void AddToDashboardLayout(object sender, System.EventArgs e)
        {
            if (sender is Forms.ItemCreateForm createForm)
            {
                try
                {
                    ManagerService.AddItem(createForm.ItemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "AddToDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new System.ArgumentException("Error: Unable to update item in dashboard layout.");
            }
        }
        private void FilterItemsForm_Applying(object sender, System.EventArgs e)
        {
            if (sender is Forms.ItemSieveForm filterForm)
            {
                ManagerService.ApplySieve(filterForm.SieveDTO);
                MessageBox.Show("Success!", "Apply Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
        }
        private void OrganizerForm_Load(object sender, System.EventArgs e)
        {
            RerenderDashboardLayout();
        }
        private void AddTaskButton_Click(object sender, System.EventArgs e)
        {
            using (var CreateForm = new Forms.ItemCreateForm(Interfaces.ItemType.Task))
            {
                try
                {
                    CreateForm.ItemCreated += AddToDashboardLayout;
                    CreateForm.ShowDialog();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "AddTaskButton_Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddEventButton_Click(object sender, System.EventArgs e)
        {
            using (var CreateForm = new Forms.ItemCreateForm(Interfaces.ItemType.Event))
            {
                try
                {
                    CreateForm.ItemCreated += AddToDashboardLayout;
                    CreateForm.ShowDialog();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "AddEventButton_Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void StatsButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(ManagerService.GetStatistics(), "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void FilterButton_Click(object sender, System.EventArgs e)
        {
            SieveDTO = SieveDTO ?? new Models.ItemSieveDTO();
            using (Forms.ItemSieveForm filterItemsForm = new Forms.ItemSieveForm(SieveDTO))
            {
                if(filterItemsForm.ShowDialog() == DialogResult.OK)
                {
                    ManagerService.ApplySieve(filterItemsForm.SieveDTO);
                    ResetSieveButton.Enabled = true;
                    RerenderDashboardLayout();
                }
            }
        }
        private void ResetSieveButton_Click(object sender, System.EventArgs e)
        {
            ResetSieveButton.Enabled = false;
            if(SieveDTO != null)
            {
                SieveDTO = null;
            }
            ManagerService.Reset();
            RerenderDashboardLayout();
        }
    }
}