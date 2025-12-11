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
        private OrganizerItem Item;
        public ItemDetailsForm(OrganizerItem organizerItem)
        {
            InitializeComponent();
            Item = organizerItem;
            // Depending on the type of OrganizerItem, load the appropriate control
            if (organizerItem is EventItem eventItem)
            {
                ItemControl = new EventItemControl(eventItem);
            }
            else if (organizerItem is TaskItem taskItem)
            {
                ItemControl = new TaskItemControl(taskItem);
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
            return Item;
        }

        private void OrganizerItemForm_Load(object sender, EventArgs e)
        {
            Text = Enum.GetName(typeof(ItemType), Item.Type) + " Details";
            MainButtonsFlowLayout.Visible = true;
            EditButtonsFlowLayout.Visible = false;
            ItemControl.ToggleEditMode(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Item = ItemControl.GetItem();
            ItemSaved?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Text = Enum.GetName(typeof(ItemType), Item.Type) + " Details";
            MainButtonsFlowLayout.Visible = true;
            EditButtonsFlowLayout.Visible = false;
            ItemControl.ToggleEditMode(false);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Text = "Edit " + Enum.GetName(typeof(ItemType), Item.Type);
            MainButtonsFlowLayout.Visible = false;
            EditButtonsFlowLayout.Visible = true;
            ItemControl.ToggleEditMode(true);
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
            ItemControl.ToggleEditMode(isEditMode);
        }
    }
}
