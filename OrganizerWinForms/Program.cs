using System;
using System.Windows.Forms;

namespace Organizer_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //List<OrganizerItem> testItems = GenerateTestData(20);
            //OrganizerManagerService organizerManagerService = new OrganizerManagerService(testItems);
            var organizerSqlAsyncService = new Service.OrganizerSqlAsyncService();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.ItemMainForm(organizerSqlAsyncService));
        }
    }
}
