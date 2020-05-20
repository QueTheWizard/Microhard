namespace Microhard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0358272c-853d-4f21-88c6-4e6745826123', N'admin@microhard.com', 0, N'AGP7NEYl52Qwt51HmxGW1aO3pb16/gAVgDtVfkrGKAjlE9zTZTZEDIkCay/LjifYfA==', N'ec28126d-dd7b-4f51-a0d7-3930ba35a13b', NULL, 0, 0, NULL, 1, 0, N'admin@microhard.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35138ac3-e7bd-429c-aa0f-ac9f167d86b6', N'asd@asd.com', 0, N'AHOeo+vhlqDLYG8fJGzk2jKH1dXAlI0RykxLl3GUmvUx2fSwzLx+Wkv5pSuHKFzS3Q==', N'71b9921e-971d-4014-999e-6e3db08eb355', NULL, 0, 0, NULL, 1, 0, N'asd@asd.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'65c4b5c3-14a9-404e-9f9b-498b5e49636a', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0358272c-853d-4f21-88c6-4e6745826123', N'65c4b5c3-14a9-404e-9f9b-498b5e49636a')

");
        }
        
        public override void Down()
        {
        }
    }
}
