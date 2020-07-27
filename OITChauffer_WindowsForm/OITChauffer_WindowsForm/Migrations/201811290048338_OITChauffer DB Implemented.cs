namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OITChaufferDBImplemented : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        VehicleType = c.Int(nullable: false),
                        LicensePlateNumber = c.String(nullable: false),
                        SystemAdmin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.DriverId)
                .ForeignKey("dbo.SystemAdmins", t => t.SystemAdmin_AdminId)
                .Index(t => t.SystemAdmin_AdminId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationId = c.Int(nullable: false, identity: true),
                        DriverFirstName = c.String(nullable: false, maxLength: 255),
                        VehicleType = c.Int(nullable: false),
                        LicensePlateNum = c.String(nullable: false, maxLength: 255),
                        ETA = c.DateTime(nullable: false),
                        Driver_DriverId = c.Int(),
                        SystemAdmin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.NotificationId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .ForeignKey("dbo.SystemAdmins", t => t.SystemAdmin_AdminId)
                .Index(t => t.Driver_DriverId)
                .Index(t => t.SystemAdmin_AdminId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PaymentType = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Driver_DriverId = c.Int(),
                        Rider_RiderId = c.Int(),
                        SystemAdmin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .ForeignKey("dbo.Riders", t => t.Rider_RiderId)
                .ForeignKey("dbo.SystemAdmins", t => t.SystemAdmin_AdminId)
                .Index(t => t.Driver_DriverId)
                .Index(t => t.Rider_RiderId)
                .Index(t => t.SystemAdmin_AdminId);
            
            CreateTable(
                "dbo.RideRequests",
                c => new
                    {
                        RideRequestId = c.Int(nullable: false, identity: true),
                        RiderId = c.Int(nullable: false),
                        PickupLocation = c.String(nullable: false, maxLength: 255),
                        DesiredPickupTime = c.DateTime(nullable: false),
                        RideStatus = c.Int(nullable: false),
                        Driver_DriverId = c.Int(),
                        SystemAdmin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.RideRequestId)
                .ForeignKey("dbo.Riders", t => t.RiderId, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .ForeignKey("dbo.SystemAdmins", t => t.SystemAdmin_AdminId)
                .Index(t => t.RiderId)
                .Index(t => t.Driver_DriverId)
                .Index(t => t.SystemAdmin_AdminId);
            
            CreateTable(
                "dbo.Riders",
                c => new
                    {
                        RiderId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        SystemAdmin_AdminId = c.Int(),
                    })
                .PrimaryKey(t => t.RiderId)
                .ForeignKey("dbo.SystemAdmins", t => t.SystemAdmin_AdminId)
                .Index(t => t.SystemAdmin_AdminId);
            
            CreateTable(
                "dbo.SystemAdmins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.Riders", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.RideRequests", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.Notifications", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.Drivers", "SystemAdmin_AdminId", "dbo.SystemAdmins");
            DropForeignKey("dbo.RideRequests", "Driver_DriverId", "dbo.Drivers");
            DropForeignKey("dbo.RideRequests", "RiderId", "dbo.Riders");
            DropForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders");
            DropForeignKey("dbo.Payments", "Driver_DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Notifications", "Driver_DriverId", "dbo.Drivers");
            DropIndex("dbo.Riders", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.RideRequests", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.RideRequests", new[] { "Driver_DriverId" });
            DropIndex("dbo.RideRequests", new[] { "RiderId" });
            DropIndex("dbo.Payments", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.Payments", new[] { "Rider_RiderId" });
            DropIndex("dbo.Payments", new[] { "Driver_DriverId" });
            DropIndex("dbo.Notifications", new[] { "SystemAdmin_AdminId" });
            DropIndex("dbo.Notifications", new[] { "Driver_DriverId" });
            DropIndex("dbo.Drivers", new[] { "SystemAdmin_AdminId" });
            DropTable("dbo.SystemAdmins");
            DropTable("dbo.Riders");
            DropTable("dbo.RideRequests");
            DropTable("dbo.Payments");
            DropTable("dbo.Notifications");
            DropTable("dbo.Drivers");
        }
    }
}
