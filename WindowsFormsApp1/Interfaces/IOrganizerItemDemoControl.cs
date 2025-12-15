using System;
using System.Windows.Forms;

namespace Organizer_Project.Interfaces
{
    public interface IOrganizerItemDemoControl
    {
        event EventHandler ItemDetailsRequested;
        event EventHandler ItemEdited;
        event EventHandler ItemDeleted;
        BindingSource ItemSource { get; }
        int ItemPosition { get; set; }
        void Action();
        OrganizerItem GetItem();
    }
}
