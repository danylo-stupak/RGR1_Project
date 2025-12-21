using System.Collections.Generic;

namespace Organizer_Project.Datas
{
    public class EventItemDataGenerator : Interfaces.IDataGenerator<Models.EventItem>
    {
        // Fields
        private static readonly string[] EventTopics =
        {
            "Team Sync",
            "Dentist",
            "University Lecture",
            "Lunch with Friend",
            "Project Review"
        };
        private static readonly string[] EventNotes =
        {
            "Meeting in Discord.",
            "Meetimg at office.",
            "Meeting in 404 audience room.",
            "Meeting in \"Celentano\" pizzeria.",
            "Meeting in Figma."
        };
        private readonly System.Random RandomSeed = new System.Random();
        private readonly System.DateTime Time = System.DateTime.Now.Date;
        private readonly int EnumPriorityCount = System.Enum.GetNames(typeof(Interfaces.Priority)).Length;
        // Properties
        private string RandomTopic => EventTopics[RandomSeed.Next(0, EventTopics.Length)];
        private string RandomNote => EventNotes[RandomSeed.Next(0, EventNotes.Length)];
        // Interface member implementations
        public Models.EventItem GenerateData()
        {
            return GenerateData(RandomSeed.Next());
        }
        public Models.EventItem GenerateData(int index)
        {
            var startTime = Time.AddHours(RandomSeed.Next(1, 12)).AddDays(RandomSeed.Next(-15, 15)).AddMonths(RandomSeed.Next(-6, 6));
            return new Models.EventItem
            (
                title: $"Event {index}: {RandomTopic}",
                priority: (Interfaces.Priority)RandomSeed.Next(0, EnumPriorityCount),
                startTime: startTime,
                endTime: startTime.AddHours(RandomSeed.Next(1, 12)).AddDays(RandomSeed.Next(0, 3)),
                notes: RandomNote,
                isAllDay: RandomSeed.Next(0, 10) > 7 // 20% chance for All Day
            );
        }
        public IEnumerable<Models.EventItem> GenerateDataList(int listCount)
        {
            List<Models.EventItem> eventItems = new List<Models.EventItem>();
            for (int i = 0; i < listCount; i++)
            {
                eventItems.Add(GenerateData(i));
            }
            return eventItems;
        }
    }
}