namespace VideoRentalApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNIDToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NID", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NID");
        }
    }
}
