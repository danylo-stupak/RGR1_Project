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
            Service.OrganizerSqlService organizerManagerService = new Service.OrganizerSqlService();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.ItemMainForm(organizerManagerService));
        }
    }
}
