namespace VideoRentalApps.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addCanManageMoviesToRoleName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'ba0250f6-b94f-4395-8bc6-e3da17913970', N'CanManageMovies')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'37789970-be79-40c7-979d-60aca069b2a7', N'ba0250f6-b94f-4395-8bc6-e3da17913970')");

        }

        public override void Down()
        {
        }
    }
}
