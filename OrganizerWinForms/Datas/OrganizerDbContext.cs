using System.Data.Entity;

namespace Organizer_Project.Datas
{
    public class OrganizerDbContext : DbContext
    {
        // "OrganizerDb" matches the name in your App.config
        public OrganizerDbContext() : base("name=OrganizerDb")
        {
            // Ensures the database is created if it doesn't exist
            Database.SetInitializer(new CreateDatabaseIfNotExists<OrganizerDbContext>());
        }

        public DbSet<Interfaces.OrganizerItem> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Table-per-Hierarchy (TPH) Mapping
            // This tells EF to put both Tasks and Events in one table
            modelBuilder.Entity<Interfaces.OrganizerItem>()
                .ToTable("OrganizerItems")
                .HasKey(i => i.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}