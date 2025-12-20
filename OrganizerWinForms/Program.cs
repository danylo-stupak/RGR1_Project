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
        private static List<OrganizerItem> GenerateTestData(int count)
        {
            var items = new List<OrganizerItem>();
            var rnd = new Random();

            for (int i = 1; i <= count; i++)
            {
                // Alternate between Task and Event
                if (i % 2 == 0)
                {
                    items.Add(new TaskItem(
                        title: $"Task {i}: {GetRandomTopic(rnd)}",
                        priority: (Priority)rnd.Next(0, 3),
                        endTime: DateTime.Now.AddDays(rnd.Next(-5, 10)),
                        status: (TaskStatus)rnd.Next(0, 4),
                        group: i % 3 == 0 ? "Work" : "Personal",
                        notes: "Automatic test sample for RGR2 LINQ testing."
                    ));
                }
                else
                {
                    DateTime start = DateTime.Now.AddDays(rnd.Next(-2, 5)).AddHours(rnd.Next(1, 12));
                    items.Add(new EventItem(
                        title: $"Event {i}: {GetRandomMeeting(rnd)}",
                        priority: (Priority)rnd.Next(0, 3),
                        startTime: start,
                        endTime: start.AddHours(rnd.Next(1, 4)),
                        notes: "Testing date range and sorting logic.",
                        isAllDay: rnd.Next(0, 10) > 7 // 20% chance for All Day
                    ));
                }
            }
            return items;
        }

        private static string GetRandomTopic(Random r) =>
            (new[] { "Buy groceries", "Fix bug in C++", "Refactor DTOs", "UI/UX Research", "Finish Report" })[r.Next(0, 5)];

        private static string GetRandomMeeting(Random r) =>
            (new[] { "Team Sync", "Dentist", "University Lecture", "Lunch with Friend", "Project Review" })[r.Next(0, 5)];
    }
}
