namespace VidlyApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1d89487a-1a73-4905-8305-4e1ac6344f92', N'guest@vidly.com', 0, N'AL/npAvdZZ2MID5eCLu8WrcNtcLTfhSJBNwgNdm4oXgakh1gzXv233uA/9/Oz8niSg==', N'3fe73203-d3d8-4b01-95fb-c2ce1db08bf9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf317283-9f4e-4777-999c-ab1d58226fcb', N'admin@vidly.com', 0, N'AEkXwN4qb/1AVsXZ6AN7RR3R+Qb3IzU55RgJOtiufVuTU0AyS1th7HDaEUaVcv4MCA==', N'9c4b505c-32aa-424f-96cf-8756d133833d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'472a3882-a865-4014-a3c6-e392b2fd7ae9', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cf317283-9f4e-4777-999c-ab1d58226fcb', N'472a3882-a865-4014-a3c6-e392b2fd7ae9')

");
        }
        
        public override void Down()
        {
        }
    }
}
