namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2b7f56e7-b996-4d74-9886-e92be82fcef1', N'admin@vidly.com', 0, N'ANJoavwkDDT74oKIL7gSlwWE8DGvNtIjQgwyyhAkbJMJ+ph7uMv3befsOY1gktDl9A==', N'6bee2880-f2b2-4a7b-80b1-03369ec07d9e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35170270-aed3-4ea4-8e45-a7bf9c729cf2', N'guest@vidly.com', 0, N'ANlw1stnpiA5OLLTdEqFarwgqC/OIAjPtUvVReuYIZR5Dx60QSiQTtG6WTrC4YJZRw==', N'920e1cee-e3e0-4286-8f32-60810336f3cb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'912bda80-9532-44ba-b3dd-436d35be0d81', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2b7f56e7-b996-4d74-9886-e92be82fcef1', N'912bda80-9532-44ba-b3dd-436d35be0d81')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
