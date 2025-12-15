
using System;
using System.Windows.Forms;

namespace Organizer_Project.Interfaces
{
    public interface IOrganizerItemControl 
    {
        BindingSource ItemSource { get; }
        int ItemPosition { get; set; }
        void ToggleMode(bool isEditMode);
        OrganizerItem GetItem();
    }
}
