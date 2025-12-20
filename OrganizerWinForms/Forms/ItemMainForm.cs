using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class ItemMainForm : Form
    {
        private readonly Interfaces.IManagerAsyncService<Interfaces.OrganizerItem> ManagerAsyncService;
        private Models.ItemSieveDTO SieveDTO = null;
        public ItemMainForm(Interfaces.IManagerAsyncService<Interfaces.OrganizerItem> managerService)
        {
            InitializeComponent();
            ManagerAsyncService = managerService;
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
            int bindCount = ManagerAsyncService.BindingSource.Count;
            ManagerAsyncService.BindingSource.ResetBindings(false);
            for (int i = 0; i < bindCount; i++)
            {
                var control = Factories.DemoControlFactory.CreateDemoControl(ManagerAsyncService.BindingSource, i);
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
        private async void RemoveFromDashboardLayout(object sender, System.EventArgs e)
        {
            if (sender is Interfaces.IOrganizerItemDemoControl itemControl)
            {
                UseWaitCursor = true;
                try
                {
                    await ManagerAsyncService.DeleteItemAsync(itemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "RemoveFromDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    UseWaitCursor = false;
                }
            }
        }
        private async void UpdateDashboardLayout(object sender, System.EventArgs e)
        {
            if (sender is Forms.ItemDetailsForm detailsForm)
            {
                UseWaitCursor = true;
                try
                {
                    await ManagerAsyncService.UpdateItemAsync(detailsForm.ItemControl.GetItem());
                    RerenderDashboardLayout();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "UpdateDashboardLayout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    UseWaitCursor = false;
                }
            }
            else
            {
                throw new System.ArgumentException("Error: Unable to update item in dashboard layout.");
            }
        }
        private void OrganizerForm_Load(object sender, System.EventArgs e)
        {
            RerenderDashboardLayout();
        }
        private async void AddTaskButton_Click(object sender, System.EventArgs e)
        {
            using (var createForm = new Forms.ItemCreateForm(Interfaces.ItemType.Task))
            {
                if(createForm.ShowDialog() == DialogResult.OK)
                {
                    UseWaitCursor = true;
                    try
                    {
                        var item = createForm.ItemControl.GetItem();
                        await ManagerAsyncService.AddItemAsync(item);
                        RerenderDashboardLayout();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "AddTaskButton_Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        UseWaitCursor = false;
                    }
                }
            }
        }
        private async void AddEventButton_Click(object sender, System.EventArgs e)
        {
            using (var createForm = new Forms.ItemCreateForm(Interfaces.ItemType.Event))
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    UseWaitCursor = true;
                    try
                    {
                        var item = createForm.ItemControl.GetItem();
                        await ManagerAsyncService.AddItemAsync(item);
                        RerenderDashboardLayout();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "AddEventButton_Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        UseWaitCursor = false;
                    }
                }
            }
        }
        private async void StatsButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(await ManagerAsyncService.GetStatisticsAsync(), "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private async void FilterButton_Click(object sender, System.EventArgs e)
        {
            SieveDTO = SieveDTO ?? new Models.ItemSieveDTO();
            using (Forms.ItemSieveForm filterItemsForm = new Forms.ItemSieveForm(SieveDTO))
            {
                if(filterItemsForm.ShowDialog() == DialogResult.OK)
                {
                    UseWaitCursor = true;
                    try
                    {
                        ResetSieveButton.Enabled = true;
                        await ManagerAsyncService.ApplySieveAsync(filterItemsForm.SieveDTO);
                        RerenderDashboardLayout();
                    }
                    finally
                    {
                        UseWaitCursor = false;
                    }
                }
            }
        }
        private async void ResetSieveButton_Click(object sender, System.EventArgs e)
        {
            ResetSieveButton.Enabled = false;
            if(SieveDTO != null)
            {
                SieveDTO = null;
            }
            UseWaitCursor = true;
            try
            {
                await ManagerAsyncService.ResetAsync();
                RerenderDashboardLayout();
            }
            finally
            {
                UseWaitCursor = false;
            }
        }
    }
}