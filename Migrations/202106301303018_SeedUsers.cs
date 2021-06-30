namespace VideoRentalApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'114a48e6-6e4b-4223-bec8-8a26fd3e2425', N'muntasir@Rental.com', 0, N'AFXo5qJZpa7fGpA7dTeMEK5vjXkcr5XaLQrF7p6YUUYCXReOy/xOytLWaOaL9npFKw==', N'0d4c6b4b-3a99-47ce-a935-500d44f59d27', NULL, 0, 0, NULL, 1, 0, N'muntasir@Rental.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'37789970-be79-40c7-979d-60aca069b2a7', N'admin@Rental.com', 0, N'ADDA5hAtSBpbIL0swB7Oy7sN9+cI/XnFmilddPXQZ/eSx+6m3HVl92IEr8hYaxm0Ug==', N'a3050b63-f153-4289-96a7-c2afb65e29ff', NULL, 0, 0, NULL, 1, 0, N'admin@Rental.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ba0250f6-b94f-4395-8bc6-e3da17913969', N'CanMangerMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'37789970-be79-40c7-979d-60aca069b2a7', N'ba0250f6-b94f-4395-8bc6-e3da17913969')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
