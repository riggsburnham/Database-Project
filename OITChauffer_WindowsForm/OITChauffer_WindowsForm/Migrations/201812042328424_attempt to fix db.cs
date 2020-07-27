namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attempttofixdb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "Rider_RiderId", c => c.Int());
            CreateIndex("dbo.Notifications", "Rider_RiderId");
            AddForeignKey("dbo.Notifications", "Rider_RiderId", "dbo.Riders", "RiderId");
            DropColumn("dbo.Notifications", "RiderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "RiderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Notifications", "Rider_RiderId", "dbo.Riders");
            DropIndex("dbo.Notifications", new[] { "Rider_RiderId" });
            DropColumn("dbo.Notifications", "Rider_RiderId");
        }
    }
}
