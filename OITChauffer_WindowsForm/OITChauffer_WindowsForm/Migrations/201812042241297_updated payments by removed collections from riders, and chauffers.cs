namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedpaymentsbyremovedcollectionsfromridersandchauffers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders");
            DropForeignKey("dbo.Payments", "Chauffer_ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.Payments", new[] { "Rider_RiderId" });
            DropIndex("dbo.Payments", new[] { "Chauffer_ChaufferId" });
            DropColumn("dbo.Payments", "Rider_RiderId");
            DropColumn("dbo.Payments", "Chauffer_ChaufferId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "Chauffer_ChaufferId", c => c.Int());
            AddColumn("dbo.Payments", "Rider_RiderId", c => c.Int());
            CreateIndex("dbo.Payments", "Chauffer_ChaufferId");
            CreateIndex("dbo.Payments", "Rider_RiderId");
            AddForeignKey("dbo.Payments", "Chauffer_ChaufferId", "dbo.Chauffers", "ChaufferId");
            AddForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders", "RiderId");
        }
    }
}
