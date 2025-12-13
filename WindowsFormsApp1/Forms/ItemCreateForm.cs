using Organizer_Project.Interfaces;
using System;
using System.Windows.Forms;
using Organizer_Project.User_Controls;
using Organizer_Project.Models;


namespace Organizer_Project.Forms
{
    public partial class ItemCreateForm : Form, IOrganizerItemControl
    {
        public event EventHandler ItemCreated;

        private IOrganizerItemControl ItemControl;
        private string ItemTypeString;
        public ItemCreateForm(ItemType itemType)
        {
            InitializeComponent();
            ItemTypeString = Enum.GetName(typeof(ItemType), itemType);
            if (itemType == ItemType.Task)
            {
                var taskItemCopy = new TaskItem();
                ItemControl = new TaskItemControl(taskItemCopy, true);
            }
            else if (itemType == ItemType.Event)
            {
                var eventItemCopy = new EventItem();
                ItemControl = new EventItemControl(eventItemCopy, true);
            }
            else
            {
                throw new ArgumentException("Invalid item type");
            }
            MainTableLayout.Controls.Add(ItemControl as UserControl, 0, 0);
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
        }

        public void ToggleMode(bool isEditMode)
        {
            ItemControl.ToggleMode(isEditMode);
        }

        public OrganizerItem GetItem()
        {
            return ItemControl.GetItem();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ItemCreated?.Invoke(this, EventArgs.Empty);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ItemCreateForm_Load(object sender, EventArgs e)
        {
            Text = "Create New " + ItemTypeString;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
