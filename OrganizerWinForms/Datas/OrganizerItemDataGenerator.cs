using System.Collections.Generic;

namespace Organizer_Project.Datas
{
    public class OrganizerItemDataGenerator : Interfaces.IDataGenerator<Interfaces.OrganizerItem>
    {
        private readonly TaskItemDataGenerator TaskGenerator = new TaskItemDataGenerator();
        private readonly EventItemDataGenerator EventGenerator = new EventItemDataGenerator();
        private readonly System.Random RandomSeed = new System.Random();
        public Interfaces.OrganizerItem GenerateData()
        {
            bool rndChoice = RandomSeed.Next() == 0;
            return rndChoice ? TaskGenerator.GenerateData() as Interfaces.OrganizerItem : EventGenerator.GenerateData() as Interfaces.OrganizerItem;
        }
        public IEnumerable<Interfaces.OrganizerItem> GenerateDataList(int listLength)
        {
            var items = new List<Interfaces.OrganizerItem>();

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