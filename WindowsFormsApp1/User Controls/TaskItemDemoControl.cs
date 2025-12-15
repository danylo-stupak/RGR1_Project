using Organizer_Project.Forms;
using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Windows.Forms;

namespace Organizer_Project.User_Controls
{
    public partial class TaskItemDemoControl : UserControl, IOrganizerItemDemoControl
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
        public TaskItemDemoControl(BindingSource source, int position)
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
            return ItemSource.Current as TaskItem;
        }
        private void TaskItemDemoControl_Load(object sender, System.EventArgs e)
        {
            // bind the item property to the control
            TypeLabel.DataBindings.Add("Text", ItemSource, "Type", true, DataSourceUpdateMode.Never);
            TitleLabel.DataBindings.Add("Text", ItemSource, "Title", true, DataSourceUpdateMode.Never);
            PriorityNameLabel.DataBindings.Add("Text", ItemSource, "Priority", true, DataSourceUpdateMode.Never);
            StatusNameLabel.DataBindings.Add("Text", ItemSource, "Status", true, DataSourceUpdateMode.Never);
            MainTimeNameLabel.DataBindings.Add("Text", ItemSource, "Time", true, DataSourceUpdateMode.Never);
        }
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ItemDetailsRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}

