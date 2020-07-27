namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gaveriderequestachaufferId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RideRequests", "Chauffer_ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.RideRequests", new[] { "Chauffer_ChaufferId" });
            RenameColumn(table: "dbo.RideRequests", name: "Chauffer_ChaufferId", newName: "ChaufferId");
            AlterColumn("dbo.RideRequests", "ChaufferId", c => c.Int(nullable: false));
            CreateIndex("dbo.RideRequests", "ChaufferId");
            AddForeignKey("dbo.RideRequests", "ChaufferId", "dbo.Chauffers", "ChaufferId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RideRequests", "ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.RideRequests", new[] { "ChaufferId" });
            AlterColumn("dbo.RideRequests", "ChaufferId", c => c.Int());
            RenameColumn(table: "dbo.RideRequests", name: "ChaufferId", newName: "Chauffer_ChaufferId");
            CreateIndex("dbo.RideRequests", "Chauffer_ChaufferId");
            AddForeignKey("dbo.RideRequests", "Chauffer_ChaufferId", "dbo.Chauffers", "ChaufferId");
        }
    }
}
