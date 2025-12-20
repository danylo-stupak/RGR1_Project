using Organizer_Project.Interfaces;
using System.Data.Entity;

namespace Organizer_Project.Data
{
    public class OrganizerDbContext : DbContext
    {
        // "OrganizerDb" matches the name in your App.config
        public OrganizerDbContext() : base("name=OrganizerDb")
        {
            // Ensures the database is created if it doesn't exist
            Database.SetInitializer(new CreateDatabaseIfNotExists<OrganizerDbContext>());
        }

        public DbSet<OrganizerItem> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Table-per-Hierarchy (TPH) Mapping
            // This tells EF to put both Tasks and Events in one table
            modelBuilder.Entity<OrganizerItem>()
                .ToTable("OrganizerItems")
                .HasKey(i => i.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}