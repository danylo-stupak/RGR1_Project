using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using Organizer_Project.Service;
using System;
using System.Collections.Generic;
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
            var organizerSqlService = new OrganizerSqlService();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ItemMainForm(organizerSqlService));
        }
    }
}
