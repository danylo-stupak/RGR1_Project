using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using Organizer_Project.User_Controls;
using System;
using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    internal partial class ItemDetailsForm : Form, IOrganizerItemControl
    {
        public event EventHandler ItemSaved;
        public event EventHandler ItemDeleted;

        private IOrganizerItemControl ItemControl;
        private OrganizerItem OrganizerItem;
        private string ItemTypeString;
        public ItemDetailsForm(OrganizerItem organizerItem)
        {
            InitializeComponent();
            ItemTypeString = Enum.GetName(typeof(ItemType), organizerItem.Type);
            OrganizerItem = organizerItem;
            if (organizerItem is EventItem eventItem)
            {
                EventItem eventItemCopy = new EventItem(eventItem);     // Create a copy to avoid modifying the original until saved
                ItemControl = new EventItemControl(eventItemCopy);
            }
            else if (organizerItem is TaskItem taskItem)
            {
                TaskItem taskItemCopy = new TaskItem(taskItem);     // Create a copy to avoid modifying the original until saved
                ItemControl = new TaskItemControl(taskItemCopy);
            }
            else
            {
                throw new ArgumentException("Unsupported OrganizerItem type");
            }
            MainTableLayout.Controls.Add(ItemControl as UserControl, 0, 1);
            MainTableLayout.SetColumnSpan(ItemControl as UserControl, 2);
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
        }

        public OrganizerItem GetItem()
        {
            return ItemControl.GetItem();
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
                    ItemSaved?.Invoke(this, EventArgs.Empty);
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
            ItemControl.GetItem().UpdateFrom(OrganizerItem); // Revert changes by updating from the original item
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
                DialogResult = DialogResult.OK;
                ItemDeleted?.Invoke(this, EventArgs.Empty);
                Close();
            }
        }

        public void ToggleMode(bool isEditMode)
        {
            Text = isEditMode ? "Edit " + ItemTypeString : ItemTypeString + " Details";
            MainButtonsFlowLayout.Visible = !isEditMode;
            EditButtonsFlowLayout.Visible = isEditMode;
            BackButton.Visible = !isEditMode;
            ItemControl.ToggleMode(isEditMode);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
