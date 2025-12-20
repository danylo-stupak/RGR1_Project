namespace Organizer_Project.Migrations
{
    using Organizer_Project.Data;
    using Organizer_Project.Interfaces;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Organizer_Project.Data.OrganizerDbContext>
    {
        private readonly int SEED_SAMPLE_SIZE = 5;
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Organizer_Project.Data.OrganizerDbContext";
        }

        protected override void Seed(Organizer_Project.Data.OrganizerDbContext context)
        {
            // Only add data if the database is empty
            if (!context.Items.Any())
            {
                IDataGenerator<OrganizerItem> dataGenerator = new OrganizerItemGenerator();
                List<OrganizerItem> organizerItems = dataGenerator.GenerateDataList(SEED_SAMPLE_SIZE) as List<OrganizerItem>;
                context.Items.AddRange(organizerItems);
            }
        }
    }
}