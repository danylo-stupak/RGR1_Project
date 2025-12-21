using System.Windows.Forms;

namespace Organizer_Project.Forms
{
    public partial class ItemCreateForm : Form
    {
        public Interfaces.IOrganizerItemControl ItemControl;
        private readonly string ItemTypeString;
        public ItemCreateForm(Interfaces.ItemType type)
        {
            InitializeComponent();
            ItemControl = Factories.ControlFactory.CreateControl(type, true);
            ItemTypeString = System.Enum.GetName(typeof(Interfaces.ItemType), type);
            MainTableLayout.Controls.Add(ItemControl as UserControl, 0, 0);
            ((UserControl)ItemControl).Dock = DockStyle.Fill;
        }
        private void CreateButton_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void ItemCreateForm_Load(object sender, System.EventArgs e)
        {
            Text = "Create New " + ItemTypeString;
        }
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
