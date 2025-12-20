namespace Organizer_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrganizerItems", "Type", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrganizerItems", "Type", c => c.Int(nullable: false));
        }
    }
}
