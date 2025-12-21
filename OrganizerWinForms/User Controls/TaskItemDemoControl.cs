using System.Windows.Forms;

namespace Organizer_Project.UserControls
{
    public partial class TaskItemDemoControl : UserControl, Interfaces.IOrganizerItemDemoControl
    {
        public event System.EventHandler ItemDetailsRequested;
        public event System.EventHandler ItemEdited;
        public event System.EventHandler ItemDeleted;
        public BindingSource ItemSource { get; }
        public int ItemPosition
        { 
            get => ItemSource.Position;
            set => ItemSource.Position = value;
        }
        public TaskItemDemoControl(BindingSource source, int position)
        {
            InitializeComponent();
            ItemSource = source;
            ItemPosition = position;
        }
        public void Action()
        {
            using (var detailsForm = new Forms.ItemDetailsForm(ItemSource, ItemPosition))
            {
                try
                {
                    var result = detailsForm.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:       // edit
                            ItemEdited?.Invoke(detailsForm, new System.EventArgs());
                            break;
                        case DialogResult.Abort:    // delete
                            ItemDeleted?.Invoke(this, System.EventArgs.Empty);
                            break;
                        default:
                            break;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Action Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Interfaces.OrganizerItem GetItem()
        {
            ItemSource.EndEdit();
            return ItemSource.Current as Models.TaskItem;
        }
        private void ConfigureDateTimePickers(object sender, ConvertEventArgs cevent)
        {
            string format = "ddd, dd MMM";
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;
            cevent.Value = ((System.DateTime)cevent.Value).ToString(format);
        }
        private void TaskItemDemoControl_Load(object sender, System.EventArgs e)
        {
            // Bind the item property to the control
            TypeLabel.DataBindings.Add("Text", ItemSource, "Type", true, DataSourceUpdateMode.Never);
            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.Never);
            PriorityValueLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.Never);
            StatusValueLabel.DataBindings.Add("Text", ItemSource, "Status", true, DataSourceUpdateMode.Never);
            MainTimeValueLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.Never);
            // Format datetime appearence
            ItemSource.CurrencyManager.Bindings[4].Format += new ConvertEventHandler(ConfigureDateTimePickers);
        }
        private void DetailsButton_Click(object sender, System.EventArgs e)
        {
            ItemDetailsRequested?.Invoke(this, System.EventArgs.Empty);
        }
    }
}

