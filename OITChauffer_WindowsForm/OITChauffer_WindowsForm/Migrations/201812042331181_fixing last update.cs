namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixinglastupdate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Notifications", name: "Rider_RiderId", newName: "RiderId");
            RenameIndex(table: "dbo.Notifications", name: "IX_Rider_RiderId", newName: "IX_RiderId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Notifications", name: "IX_RiderId", newName: "IX_Rider_RiderId");
            RenameColumn(table: "dbo.Notifications", name: "RiderId", newName: "Rider_RiderId");
        }
    }
}
