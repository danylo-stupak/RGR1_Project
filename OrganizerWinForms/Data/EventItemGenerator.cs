using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections.Generic;

namespace Organizer_Project.Data
{
    public class EventItemGenerator : IDataGenerator<EventItem>
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
        private readonly Random RandomSeed = new Random();
        private readonly DateTime Time = DateTime.Now.Date;
        private readonly int EnumPriorityCount = Enum.GetNames(typeof(Priority)).Length;
        // Properties
        private string RandomTopic => EventTopics[RandomSeed.Next(0, EventTopics.Length)];
        private string RandomNote => EventNotes[RandomSeed.Next(0, EventNotes.Length)];
        // Interface member implementations
        public EventItem GenerateData()
        {
            return GenerateData(RandomSeed.Next());
        }
        public EventItem GenerateData(int index)
        {
            var startTime = Time.AddHours(RandomSeed.Next(1, 12)).AddDays(RandomSeed.Next(-15, 15)).AddMonths(RandomSeed.Next(-6, 6));
            return new EventItem
            (
                title: $"Event {index}: {RandomTopic}",
                priority: (Priority)RandomSeed.Next(0, EnumPriorityCount),
                startTime: startTime,
                endTime: startTime.AddHours(RandomSeed.Next(1, 12)).AddDays(RandomSeed.Next(0, 3)),
                notes: RandomNote,
                isAllDay: RandomSeed.Next(0, 10) > 7 // 20% chance for All Day
            );
        }
        public IEnumerable<EventItem> GenerateDataList(int listCount)
        {
            List<EventItem> eventItems = new List<EventItem>();
            for (int i = 0; i < listCount; i++)
            {
                eventItems.Add(GenerateData(i));
            }
            return eventItems;
        }
    }
}