namespace VideoRentalApps.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [NID], [Phone]) VALUES (N'114a48e6-6e4b-4223-bec8-8a26fd3e2425', N'muntasir@Rental.com', 0, N'AFXo5qJZpa7fGpA7dTeMEK5vjXkcr5XaLQrF7p6YUUYCXReOy/xOytLWaOaL9npFKw==', N'0d4c6b4b-3a99-47ce-a935-500d44f59d27', NULL, 0, 0, NULL, 1, 0, N'muntasir@Rental.com', N'', N'')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [NID], [Phone]) VALUES (N'25878fa8-f898-41b4-a6cf-85cedb4f2a68', N'dhrubainvisible@gmail.com', 0, NULL, N'cd617fa2-f03b-4706-93c7-c5ec1b32a4d6', NULL, 0, 0, NULL, 1, 0, N'dhrubainvisible@gmail.com', N'Abc12345!', N'')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [NID], [Phone]) VALUES (N'37789970-be79-40c7-979d-60aca069b2a7', N'admin@Rental.com', 0, N'ADDA5hAtSBpbIL0swB7Oy7sN9+cI/XnFmilddPXQZ/eSx+6m3HVl92IEr8hYaxm0Ug==', N'a3050b63-f153-4289-96a7-c2afb65e29ff', NULL, 0, 0, NULL, 1, 0, N'admin@Rental.com', N'', N'')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [NID], [Phone]) VALUES (N'4d9f48db-fad8-45db-8814-8830960f0f70', N'Superadmin@Rental.com', 0, N'AAKksiQk0r3J5BtVEmv+pShpxHqyzy0IS7863w9zwK8j/gQKT10BpLVdESNyzjyrOA==', N'ba9e2f8d-81d2-4a89-a82d-8f05f4852f4b', NULL, 0, 0, NULL, 1, 0, N'Superadmin@Rental.com', N'1111111', N'0147896')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [NID], [Phone]) VALUES (N'e12c82f6-f245-4871-b354-4737e983ce06', N'NID@Rental.com', 0, N'ANsqsoXJiHrHa5LhcMVhs98vUL+i5f2gNM7ygV+fPtt+MTthCox/rcgm+Hq0e94Nyw==', N'7c68eb04-6c31-40b7-920c-7918cef594af', NULL, 0, 0, NULL, 1, 0, N'NID@Rental.com', N'Abc12345!', N'')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9c27d65b-8c2e-4761-be1e-b02c76ea407e', N'CanManageCustomers')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ba0250f6-b94f-4395-8bc6-e3da17913969', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4d9f48db-fad8-45db-8814-8830960f0f70', N'9c27d65b-8c2e-4761-be1e-b02c76ea407e')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'37789970-be79-40c7-979d-60aca069b2a7', N'ba0250f6-b94f-4395-8bc6-e3da17913969')

            ");
        }

        public override void Down()
        {
        }
    }
}
