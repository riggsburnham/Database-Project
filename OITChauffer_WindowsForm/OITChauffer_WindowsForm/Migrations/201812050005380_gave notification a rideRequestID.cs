namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gavenotificationarideRequestID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "RideRequestId", c => c.Int());
            CreateIndex("dbo.Notifications", "RideRequestId");
            AddForeignKey("dbo.Notifications", "RideRequestId", "dbo.RideRequests", "RideRequestId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "RideRequestId", "dbo.RideRequests");
            DropIndex("dbo.Notifications", new[] { "RideRequestId" });
            DropColumn("dbo.Notifications", "RideRequestId");
        }
    }
}
