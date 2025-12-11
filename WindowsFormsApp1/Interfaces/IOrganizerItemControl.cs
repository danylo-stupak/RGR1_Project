
namespace Organizer_Project.Interfaces
{
    internal interface IOrganizerItemControl
    {
        OrganizerItem GetItem();
        void ToggleEditMode(bool isEditMode);
    }
}
