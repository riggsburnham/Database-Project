namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeddrivernametoreflectproject : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Notifications", "Driver_DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Payments", "Driver_DriverId", "dbo.Drivers");
            DropForeignKey("dbo.RideRequests", "Driver_DriverId", "dbo.Drivers");
            DropIndex("dbo.Notifications", new[] { "Driver_DriverId" });
            DropIndex("dbo.Payments", new[] { "Driver_DriverId" });
            DropIndex("dbo.RideRequests", new[] { "Driver_DriverId" });
            CreateTable(
                "dbo.Chauffers",
                c => new
                    {
                        ChaufferId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        VehicleType = c.Int(nullable: false),
                        LicensePlateNumber = c.String(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ChaufferId);
            
            AddColumn("dbo.Notifications", "Chauffer_ChaufferId", c => c.Int());
            AddColumn("dbo.Payments", "Chauffer_ChaufferId", c => c.Int());
            AddColumn("dbo.RideRequests", "Chauffer_ChaufferId", c => c.Int());
            CreateIndex("dbo.Notifications", "Chauffer_ChaufferId");
            CreateIndex("dbo.Payments", "Chauffer_ChaufferId");
            CreateIndex("dbo.RideRequests", "Chauffer_ChaufferId");
            AddForeignKey("dbo.Notifications", "Chauffer_ChaufferId", "dbo.Chauffers", "ChaufferId");
            AddForeignKey("dbo.Payments", "Chauffer_ChaufferId", "dbo.Chauffers", "ChaufferId");
            AddForeignKey("dbo.RideRequests", "Chauffer_ChaufferId", "dbo.Chauffers", "ChaufferId");
            DropColumn("dbo.Notifications", "Driver_DriverId");
            DropColumn("dbo.Payments", "Driver_DriverId");
            DropColumn("dbo.RideRequests", "Driver_DriverId");
            DropTable("dbo.Drivers");
        }
        
        public override void Down()
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
                        UserName = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.DriverId);
            
            AddColumn("dbo.RideRequests", "Driver_DriverId", c => c.Int());
            AddColumn("dbo.Payments", "Driver_DriverId", c => c.Int());
            AddColumn("dbo.Notifications", "Driver_DriverId", c => c.Int());
            DropForeignKey("dbo.RideRequests", "Chauffer_ChaufferId", "dbo.Chauffers");
            DropForeignKey("dbo.Payments", "Chauffer_ChaufferId", "dbo.Chauffers");
            DropForeignKey("dbo.Notifications", "Chauffer_ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.RideRequests", new[] { "Chauffer_ChaufferId" });
            DropIndex("dbo.Payments", new[] { "Chauffer_ChaufferId" });
            DropIndex("dbo.Notifications", new[] { "Chauffer_ChaufferId" });
            DropColumn("dbo.RideRequests", "Chauffer_ChaufferId");
            DropColumn("dbo.Payments", "Chauffer_ChaufferId");
            DropColumn("dbo.Notifications", "Chauffer_ChaufferId");
            DropTable("dbo.Chauffers");
            CreateIndex("dbo.RideRequests", "Driver_DriverId");
            CreateIndex("dbo.Payments", "Driver_DriverId");
            CreateIndex("dbo.Notifications", "Driver_DriverId");
            AddForeignKey("dbo.RideRequests", "Driver_DriverId", "dbo.Drivers", "DriverId");
            AddForeignKey("dbo.Payments", "Driver_DriverId", "dbo.Drivers", "DriverId");
            AddForeignKey("dbo.Notifications", "Driver_DriverId", "dbo.Drivers", "DriverId");
        }
    }
}
