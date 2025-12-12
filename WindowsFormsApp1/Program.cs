using Organizer_Project.Interfaces;
using Organizer_Project.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Organizer_Project.Models;

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
            List<OrganizerItem> items = new List<OrganizerItem>();
            //items.Add(new TaskItem
            //{
            //    Id = Guid.NewGuid(),
            //    Type = ItemType.Task,
            //    Priority = Priority.High,
            //    Title = "Finish Project Report",
            //    Notes = "Complete the final report for the project and submit it to the manager.",
            //    Time = DateTime.Now.AddHours(4)
            //});
            //items.Add(new EventItem
            //{
            //    Id = Guid.NewGuid(),
            //    Type = ItemType.Event,
            //    Priority = Priority.Medium,
            //    Title = "Team Meeting",
            //    Notes = "Weekly sync-up with the team to discuss project progress.",
            //    Time = DateTime.Now.AddHours(2)
            //});


            OrganizerManagerService organizerManagerService = new OrganizerManagerService(items);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrganizerForm(organizerManagerService));
        }
    }
}
