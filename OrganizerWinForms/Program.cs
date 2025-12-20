using System.Windows.Forms;

namespace Organizer_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            Services.OrganizerSqlService organizerManagerService = new Services.OrganizerSqlService();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.ItemMainForm(organizerManagerService));
        }
    }
}
