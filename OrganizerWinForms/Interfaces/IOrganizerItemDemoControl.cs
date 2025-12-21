using System.Windows.Forms;

namespace Organizer_Project.Interfaces
{
    public interface IOrganizerItemDemoControl
    {
        event System.EventHandler ItemDetailsRequested;
        event System.EventHandler ItemEdited;
        event System.EventHandler ItemDeleted;
        BindingSource ItemSource { get; }
        int ItemPosition { get; set; }
        void Action();
        OrganizerItem GetItem();
    }
}
