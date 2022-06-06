namespace Vidly_Clone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'52c6f97e-46f2-45b2-b06c-f95d6fc9609f', N'admin@vidly-clone.com', 0, N'AMXj2STAHLbmlkoFWgONXzFVl7vLsD0D2W++3LepMALli1wnH11B78zLtBeqEThbCw==', N'e44069ce-002c-4836-bbed-3fe9febdc056', NULL, 0, 0, NULL, 1, 0, N'admin@vidly-clone.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f098e12a-19c9-45b9-aeb2-f53e817a8f44', N'admin2@vidly-clone.com', 0, N'AJ4XnFNxABTKCUf9cWglo+SeJVa4E9sSNxUZWN7gLUbydX7uK+ouS7DeQy+g4q2zVg==', N'd632347c-0c6a-4282-98ca-7fc33d10745a', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly-clone.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e5f8785-8076-45e8-8ea0-0ce5f45c8ca6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'52c6f97e-46f2-45b2-b06c-f95d6fc9609f', N'7e5f8785-8076-45e8-8ea0-0ce5f45c8ca6')



");
        }
        
        public override void Down()
        {
        }
    }
}
