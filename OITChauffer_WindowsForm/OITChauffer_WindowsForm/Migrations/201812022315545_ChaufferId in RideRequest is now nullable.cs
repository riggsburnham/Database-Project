namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChaufferIdinRideRequestisnownullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RideRequests", "ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.RideRequests", new[] { "ChaufferId" });
            AlterColumn("dbo.RideRequests", "ChaufferId", c => c.Int());
            CreateIndex("dbo.RideRequests", "ChaufferId");
            AddForeignKey("dbo.RideRequests", "ChaufferId", "dbo.Chauffers", "ChaufferId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RideRequests", "ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.RideRequests", new[] { "ChaufferId" });
            AlterColumn("dbo.RideRequests", "ChaufferId", c => c.Int(nullable: false));
            CreateIndex("dbo.RideRequests", "ChaufferId");
            AddForeignKey("dbo.RideRequests", "ChaufferId", "dbo.Chauffers", "ChaufferId", cascadeDelete: true);
        }
    }
}
