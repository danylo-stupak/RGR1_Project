using System;
using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class ItemCreateForm : Form
    {
        public event EventHandler ItemCreated;
        public Interfaces.IOrganizerItemControl ItemControl;
        private readonly string ItemTypeString;
        public ItemCreateForm(Interfaces.ItemType type)
        {
            InitializeComponent();
            ItemControl = Factories.ControlFactory.CreateControl(type, true);
            ItemTypeString = Enum.GetName(typeof(Interfaces.ItemType), type);

            MainTableLayout.Controls.Add(ItemControl as UserControl, 0, 0);
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
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
