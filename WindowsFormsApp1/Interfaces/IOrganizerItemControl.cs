
namespace Organizer_Project.Interfaces
{
    internal interface IOrganizerItemControl
    {
        OrganizerItem GetItem();
        void ToggleMode(bool isEditMode);
    }
}
