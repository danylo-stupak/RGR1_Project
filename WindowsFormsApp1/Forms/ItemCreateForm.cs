using Organizer_Project.Interfaces;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organizer_Project.User_Controls;
using Organizer_Project.Models;


namespace Organizer_Project.Forms
{
    public partial class ItemCreateForm : Form, IOrganizerItemControl
    {
        public event EventHandler ItemCreated;

        private OrganizerItem Item;
        private IOrganizerItemControl ItemControl;
        public ItemCreateForm(ItemType itemType)
        {
            InitializeComponent();
            if (itemType == ItemType.Task)
            {
                Item = new TaskItem();
                ItemControl = new TaskItemControl(Item as TaskItem, true);
            }
            else if (itemType == ItemType.Event)
            {
                Item = new EventItem();
                ItemControl = new EventItemControl(Item as EventItem);
            }
            else
            {
                throw new ArgumentException("Invalid item type");
            }
            MainTableLayout.Controls.Add(ItemControl as UserControl, 0, 0);
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
        }

        public void ToggleEditMode(bool isEditMode)
        {
            ItemControl.ToggleEditMode(isEditMode);
        }

        public OrganizerItem GetItem()
        {
            return Item;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    Item = ItemControl.GetItem();
                    ItemCreated?.Invoke(this, EventArgs.Empty);
                    Close();
                }
                else
                {
                    MessageBox.Show("Please correct the validation errors before creating the item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemCreateForm_Load(object sender, EventArgs e)
        {
            Text = "Create New " + Enum.GetName(typeof(ItemType), Item.Type);
            ItemControl.ToggleEditMode(true);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
