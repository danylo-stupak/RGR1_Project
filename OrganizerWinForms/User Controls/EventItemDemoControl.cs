using System;
using System.Windows.Forms;

namespace Organizer_Project.UserControls
{
    public partial class EventItemDemoControl : UserControl, Interfaces.IOrganizerItemDemoControl
    {
        public event EventHandler ItemDetailsRequested;
        public event EventHandler ItemEdited;
        public event EventHandler ItemDeleted;
        public BindingSource ItemSource { get; }
        public int ItemPosition
        {
            get => ItemSource.Position;
            set => ItemSource.Position = value;
        }
        public EventItemDemoControl(BindingSource source, int position)
        {
            InitializeComponent();
            ItemSource = source;
            ItemPosition = position;
        }
        public void Action()
        {
            using (var detailsForm = new ItemDetailsForm(ItemSource, ItemPosition))
            {
                try
                {
                    var result = detailsForm.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.OK:       // edit
                            ItemEdited?.Invoke(detailsForm, new EventArgs());
                            break;
                        case DialogResult.Abort:    // delete
                            ItemDeleted?.Invoke(this, EventArgs.Empty);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Action Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public OrganizerItem GetItem()
        {
            ItemSource.EndEdit();
            return ItemSource.Current as EventItem;
        }
        private void ConfigureDateTimePickers(object sender, ConvertEventArgs cevent)
        {
            bool isCheched = (ItemSource.Current as EventItem).IsAllDay;
            string format = isCheched ? "ddd, dd MMM" : "ddd, dd MMM - HH:mm";
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            cevent.Value = ((DateTime)cevent.Value).ToString(format);
        }
        private void EventItemDemoControl_Load(object sender, System.EventArgs e)
        {
            // bind the item property to the control
            TypeLabel.DataBindings.Add("Text", ItemSource, "Type", true, DataSourceUpdateMode.Never);
            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.Never);
            PriorityValueLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.Never);
            MainTimeValueLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.Never);
            EndTimeValueLabel.DataBindings.Add("Text", ItemSource, "EndTime", true, DataSourceUpdateMode.Never);
            
            ItemSource.CurrencyManager.Bindings[3].Format += new ConvertEventHandler(ConfigureDateTimePickers);
            ItemSource.CurrencyManager.Bindings[4].Format += new ConvertEventHandler(ConfigureDateTimePickers);
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ItemDetailsRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}

