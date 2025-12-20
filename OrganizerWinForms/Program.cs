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
            Services.OrganizerSqlAsyncService organizerSqlAsyncService = new Services.OrganizerSqlAsyncService();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.ItemMainForm(organizerSqlAsyncService));
        }
    }
}
