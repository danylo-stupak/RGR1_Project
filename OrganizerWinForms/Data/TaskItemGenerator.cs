using Organizer_Project.Interfaces;
using Organizer_Project.Models;
using System;
using System.Collections.Generic;

namespace Organizer_Project.Data
{
    public class TaskItemGenerator : IDataGenerator<TaskItem>
    {
        // Fields
        private static readonly string[] TaskTopics =
        {
            "Buy groceries",
            "Fix bug in C++",
            "Refactor DTOs",
            "UI/UX Research",
            "Finish Report"
        };
        private static readonly string[] TaskNotes =
        {
            "Eggs, Milk, Coffe, Salad, Sausages.",
            "Think positively.",
            "Make right decisions.",
            "Sleep well.",
            "Don't forget."
        };
        private readonly Random RandomSeed = new Random();
        private readonly DateTime Time = DateTime.Now.Date;
        private readonly int EnumPriorityCount = Enum.GetNames(typeof(Priority)).Length;
        private readonly int EnumStatusCount = Enum.GetNames(typeof(TaskStatus)).Length;
        // Properties
        private string RandomTopic => TaskTopics[RandomSeed.Next(0, TaskTopics.Length)];
        private string RandomNotes => TaskNotes[RandomSeed.Next(0, TaskNotes.Length)];
        // Interface member implementations
        public TaskItem GenerateData()
        {
            return GenerateData(RandomSeed.Next());
        }
        public TaskItem GenerateData(int index)
        {
            return new TaskItem
            (
                title: $"Task {index}: {RandomTopic}",
                priority: (Priority)RandomSeed.Next(0, EnumPriorityCount),
                status: (TaskStatus)RandomSeed.Next(0, EnumStatusCount),
                endTime: Time.AddHours(RandomSeed.Next(1, 12)).AddDays(RandomSeed.Next(-15, 15)).AddMonths(RandomSeed.Next(-6, 6)),
                notes: RandomNotes
            );
        }
        public IEnumerable<TaskItem> GenerateDataList(int listCount)
        {
            List<TaskItem> taskItems = new List<TaskItem>();
            for (int i = 0; i < listCount; i++)
            {
                taskItems.Add(GenerateData(i));
            }
            return taskItems;
        }
    }
}