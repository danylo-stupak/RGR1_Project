namespace Organizer_Project.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Organizer_Project.Datas.OrganizerDbContext>
    {
        private readonly int SEED_SAMPLE_SIZE = 20;
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(Datas.OrganizerDbContext context)
        {
            // Only add data if the database is empty
            if (!context.Items.Any())
            {
                Interfaces.IDataGenerator<Interfaces.OrganizerItem> dataGenerator = new Datas.OrganizerItemDataGenerator();
                List<Interfaces.OrganizerItem> organizerItems = dataGenerator.GenerateDataList(SEED_SAMPLE_SIZE) as List<Interfaces.OrganizerItem>;
                context.Items.AddRange(organizerItems);
            }
        }
    }
}
