namespace VideoRentalApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesUpdate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "NumberInStoke");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumberInStoke", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
