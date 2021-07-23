namespace VideoRentalApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeUnWantedChanges : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.RoleNames");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RoleNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
