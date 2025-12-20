using Organizer_Project.Interfaces;
using Organizer_Project.Factories;
using System;
using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    internal partial class ItemDetailsForm : Form
    {
        public IOrganizerItemControl ItemControl;
        private string ItemTypeString;
        public ItemDetailsForm(BindingSource source, int position)
        {
            InitializeComponent();
            ItemControl = ControlFactory.CreateControl(source, position);
            ItemTypeString = Enum.GetName(typeof(ItemType), ItemControl.GetItem().Type);

            MainTableLayout.Controls.Add(ItemControl as UserControl, 0, 1);
            MainTableLayout.SetColumnSpan(ItemControl as UserControl, 2);
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
        }
        public void ToggleMode(bool isEditMode)
        {
            Text = isEditMode ? "Edit " + ItemTypeString : ItemTypeString + " Details";
            MainButtonsFlowLayout.Visible = !isEditMode;
            EditButtonsFlowLayout.Visible = isEditMode;
            BackButton.Visible = !isEditMode;
            ItemControl.ToggleMode(isEditMode);
        }

        private void OrganizerItemForm_Load(object sender, EventArgs e)
        {
            ToggleMode(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateChildren())
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ItemControl.ItemSource.ResetBindings(false);
            ToggleMode(false);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ToggleMode(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
