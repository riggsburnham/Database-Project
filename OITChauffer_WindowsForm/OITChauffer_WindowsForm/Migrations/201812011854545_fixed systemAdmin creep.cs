namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedsystemAdmincreep : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Drivers", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.Notifications", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.RideRequests", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.Riders", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.Payments", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropIndex("dbo.Drivers", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.Notifications", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.Payments", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.RideRequests", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.Riders", new[] { "SystemAdmin_AdminId" });
            DropColumn("dbo.Drivers", "SystemAdmin_AdminId");
            DropColumn("dbo.Notifications", "SystemAdmin_AdminId");
            DropColumn("dbo.Payments", "SystemAdmin_AdminId");
            DropColumn("dbo.RideRequests", "SystemAdmin_AdminId");
            DropColumn("dbo.Riders", "SystemAdmin_AdminId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Riders", "SystemAdmin_AdminId", c => c.Int());
            AddColumn("dbo.RideRequests", "SystemAdmin_AdminId", c => c.Int());
            AddColumn("dbo.Payments", "SystemAdmin_AdminId", c => c.Int());
            AddColumn("dbo.Notifications", "SystemAdmin_AdminId", c => c.Int());
            AddColumn("dbo.Drivers", "SystemAdmin_AdminId", c => c.Int());
            CreateIndex("dbo.Riders", "SystemAdmin_AdminId");
            CreateIndex("dbo.RideRequests", "SystemAdmin_AdminId");
            CreateIndex("dbo.Payments", "SystemAdmin_AdminId");
            CreateIndex("dbo.Notifications", "SystemAdmin_AdminId");
            CreateIndex("dbo.Drivers", "SystemAdmin_AdminId");
            AddForeignKey("dbo.Payments", "SystemAdmin_AdminId", "dbo.SystemAdmins", "AdminId");
            AddForeignKey("dbo.Riders", "SystemAdmin_AdminId", "dbo.SystemAdmins", "AdminId");
            AddForeignKey("dbo.RideRequests", "SystemAdmin_AdminId", "dbo.SystemAdmins", "AdminId");
            AddForeignKey("dbo.Notifications", "SystemAdmin_AdminId", "dbo.SystemAdmins", "AdminId");
            AddForeignKey("dbo.Drivers", "SystemAdmin_AdminId", "dbo.SystemAdmins", "AdminId");
        }
    }
}
