using System.Collections.Generic;

namespace Organizer_Project.Datas
{
    public class TaskItemDataGenerator : Interfaces.IDataGenerator<Models.TaskItem>
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
        private readonly System.Random RandomSeed = new System.Random();
        private readonly System.DateTime Time = System.DateTime.Now.Date;
        private readonly int EnumPriorityCount = System.Enum.GetNames(typeof(Interfaces.Priority)).Length;
        private readonly int EnumStatusCount = System.Enum.GetNames(typeof(Models.TaskStatus)).Length;
        // Properties
        private string RandomTopic => TaskTopics[RandomSeed.Next(0, TaskTopics.Length)];
        private string RandomNotes => TaskNotes[RandomSeed.Next(0, TaskNotes.Length)];
        // Interface member implementations
        public Models.TaskItem GenerateData()
        {
            return GenerateData(RandomSeed.Next());
        }
        public Models.TaskItem GenerateData(int index)
        {
            return new Models.TaskItem
            (
                title: $"Task {index}: {RandomTopic}",
                priority: (Interfaces.Priority)RandomSeed.Next(0, EnumPriorityCount),
                status: (Models.TaskStatus)RandomSeed.Next(0, EnumStatusCount),
                endTime: Time.AddHours(RandomSeed.Next(1, 12)).AddDays(RandomSeed.Next(-15, 15)).AddMonths(RandomSeed.Next(-6, 6)),
                notes: RandomNotes
            );
        }
        public IEnumerable<Models.TaskItem> GenerateDataList(int listCount)
        {
            List<Models.TaskItem> taskItems = new List<Models.TaskItem>();
            for (int i = 0; i < listCount; i++)
            {
                taskItems.Add(GenerateData(i));
            }
            return taskItems;
        }
    }
}