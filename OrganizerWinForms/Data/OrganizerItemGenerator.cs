using Organizer_Project.Interfaces;
using System;
using System.Collections.Generic;

namespace Organizer_Project.Data
{
    public class OrganizerItemGenerator : IDataGenerator<OrganizerItem>
    {
        private readonly TaskItemGenerator TaskGenerator = new TaskItemGenerator();
        private readonly EventItemGenerator EventGenerator = new EventItemGenerator();
        private readonly Random RandomSeed = new Random();
        public OrganizerItem GenerateData()
        {
            bool rndChoice = RandomSeed.Next() == 0;
            return rndChoice ? TaskGenerator.GenerateData() as OrganizerItem : EventGenerator.GenerateData() as OrganizerItem;
        }
        public IEnumerable<OrganizerItem> GenerateDataList(int listLength)
        {
            var items = new List<OrganizerItem>();

            for (int i = 1; i <= listLength; i++)
            {
                // Alternate between Task and Event
                if (i % 2 == 0)
                {
                    items.Add(TaskGenerator.GenerateData(i));
                }
                else
                {
                    items.Add(EventGenerator.GenerateData(i));
                }
            }
            return items;
        }
    }
}