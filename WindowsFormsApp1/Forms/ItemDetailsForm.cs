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
        private string ItemTypeString;
        private OrganizerItem OrganizerItem; // The original item being viewed/edited
        public ItemDetailsForm(OrganizerItem organizerItem)
        {
            InitializeComponent();
            OrganizerItem = organizerItem;
            ItemTypeString = Enum.GetName(typeof(ItemType), organizerItem.Type);
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
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
        }

        public OrganizerItem GetItem()
        {
            return ItemControl.GetItem();
        }

        private void OrganizerItemForm_Load(object sender, EventArgs e)
        {
            ToggleEditMode(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateChildren())
                {
                    OrganizerItem updatedItem = ItemControl.GetItem();
                    ItemSaved?.Invoke(this, EventArgs.Empty);
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
            ToggleEditMode(false);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ItemDeleted?.Invoke(this, EventArgs.Empty);
                Close();
            }
        }

        public void ToggleEditMode(bool isEditMode)
        {
            Text = isEditMode ? "Edit " + ItemTypeString : ItemTypeString + " Details";
            MainButtonsFlowLayout.Visible = !isEditMode;
            EditButtonsFlowLayout.Visible = isEditMode;
            ItemControl.ToggleEditMode(isEditMode);
        }
    }
}
