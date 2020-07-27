namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gavepaymentaRiderIdandanullableChaufferId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders");
            DropIndex("dbo.Payments", new[] { "Rider_RiderId" });
            RenameColumn(table: "dbo.Payments", name: "Chauffer_ChaufferId", newName: "ChaufferId");
            RenameColumn(table: "dbo.Payments", name: "Rider_RiderId", newName: "RiderId");
            RenameIndex(table: "dbo.Payments", name: "IX_Chauffer_ChaufferId", newName: "IX_ChaufferId");
            AlterColumn("dbo.Payments", "RiderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "RiderId");
            AddForeignKey("dbo.Payments", "RiderId", "dbo.Riders", "RiderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "RiderId", "dbo.Riders");
            DropIndex("dbo.Payments", new[] { "RiderId" });
            AlterColumn("dbo.Payments", "RiderId", c => c.Int());
            RenameIndex(table: "dbo.Payments", name: "IX_ChaufferId", newName: "IX_Chauffer_ChaufferId");
            RenameColumn(table: "dbo.Payments", name: "RiderId", newName: "Rider_RiderId");
            RenameColumn(table: "dbo.Payments", name: "ChaufferId", newName: "Chauffer_ChaufferId");
            CreateIndex("dbo.Payments", "Rider_RiderId");
            AddForeignKey("dbo.Payments", "Rider_RiderId", "dbo.Riders", "RiderId");
        }
    }
}
