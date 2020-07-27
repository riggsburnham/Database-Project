namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gavenotificationsachaufferid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Notifications", "Chauffer_ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.Notifications", new[] { "Chauffer_ChaufferId" });
            RenameColumn(table: "dbo.Notifications", name: "Chauffer_ChaufferId", newName: "ChaufferId");
            AlterColumn("dbo.Chauffers", "VehicleType", c => c.Int(nullable: false));
            AlterColumn("dbo.Notifications", "ChaufferId", c => c.Int(nullable: false));
            CreateIndex("dbo.Notifications", "ChaufferId");
            AddForeignKey("dbo.Notifications", "ChaufferId", "dbo.Chauffers", "ChaufferId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "ChaufferId", "dbo.Chauffers");
            DropIndex("dbo.Notifications", new[] { "ChaufferId" });
            AlterColumn("dbo.Notifications", "ChaufferId", c => c.Int());
            AlterColumn("dbo.Chauffers", "VehicleType", c => c.String());
            RenameColumn(table: "dbo.Notifications", name: "ChaufferId", newName: "Chauffer_ChaufferId");
            CreateIndex("dbo.Notifications", "Chauffer_ChaufferId");
            AddForeignKey("dbo.Notifications", "Chauffer_ChaufferId", "dbo.Chauffers", "ChaufferId");
        }
    }
}
