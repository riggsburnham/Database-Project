namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paymentnowonlyknowsoftherideRequestId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "RiderId", "dbo.Riders");
            DropIndex("dbo.Payments", new[] { "RiderId" });
            RenameColumn(table: "dbo.Payments", name: "ChaufferId", newName: "Chauffer_ChaufferId");
            RenameColumn(table: "dbo.Payments", name: "RiderId", newName: "Rider_RiderId");
            RenameIndex(table: "dbo.Payments", name: "IX_ChaufferId", newName: "IX_Chauffer_ChaufferId");
            AddColumn("dbo.Payments", "RideRequestId", c => c.Int(nullable: false));
            AlterColumn("dbo.Payments", "Rider_RiderId", c => c.Int());
            CreateIndex("dbo.Payments", "RideRequestId");
            CreateIndex("dbo.Payments", "Rider_RiderId");
            AddForeignKey("dbo.Payments", "RideRequestId", "dbo.RideRequests", "RideRequestId", cascadeDelete: true);
            AddForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders", "RiderId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders");
            DropForeignKey("dbo.Payments", "RideRequestId", "dbo.RideRequests");
            DropIndex("dbo.Payments", new[] { "Rider_RiderId" });
            DropIndex("dbo.Payments", new[] { "RideRequestId" });
            AlterColumn("dbo.Payments", "Rider_RiderId", c => c.Int(nullable: false));
            DropColumn("dbo.Payments", "RideRequestId");
            RenameIndex(table: "dbo.Payments", name: "IX_Chauffer_ChaufferId", newName: "IX_ChaufferId");
            RenameColumn(table: "dbo.Payments", name: "Rider_RiderId", newName: "RiderId");
            RenameColumn(table: "dbo.Payments", name: "Chauffer_ChaufferId", newName: "ChaufferId");
            CreateIndex("dbo.Payments", "RiderId");
            AddForeignKey("dbo.Payments", "RiderId", "dbo.Riders", "RiderId", cascadeDelete: true);
        }
    }
}
