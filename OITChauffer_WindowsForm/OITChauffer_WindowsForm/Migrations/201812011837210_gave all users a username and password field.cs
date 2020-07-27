namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gaveallusersausernameandpasswordfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "UserName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Drivers", "Password", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Riders", "UserName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Riders", "Password", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.SystemAdmins", "UserName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.SystemAdmins", "Password", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemAdmins", "Password");
            DropColumn("dbo.SystemAdmins", "UserName");
            DropColumn("dbo.Riders", "Password");
            DropColumn("dbo.Riders", "UserName");
            DropColumn("dbo.Drivers", "Password");
            DropColumn("dbo.Drivers", "UserName");
        }
    }
}
