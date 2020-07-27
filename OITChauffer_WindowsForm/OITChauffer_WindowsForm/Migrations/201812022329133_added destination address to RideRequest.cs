namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddestinationaddresstoRideRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RideRequests", "PickupAddress", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.RideRequests", "DestinationAddress", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.RideRequests", "PickupLocation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RideRequests", "PickupLocation", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.RideRequests", "DestinationAddress");
            DropColumn("dbo.RideRequests", "PickupAddress");
        }
    }
}
