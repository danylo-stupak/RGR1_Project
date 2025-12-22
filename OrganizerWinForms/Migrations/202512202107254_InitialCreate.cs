namespace Organizer_Project.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrganizerItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.Int(),
                        Priority = c.Int(nullable: false),
                        Title = c.String(),
                        Notes = c.String(),
                        Time = c.DateTime(nullable: false),
                        EndTime = c.DateTime(),
                        IsAllDay = c.Boolean(),
                        Status = c.Int(),
                        Group = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrganizerItems");
        }
    }
}
