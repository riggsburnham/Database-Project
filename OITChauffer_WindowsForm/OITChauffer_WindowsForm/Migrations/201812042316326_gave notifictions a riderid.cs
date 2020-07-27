namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gavenotifictionsariderid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "RiderId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "RiderId");
        }
    }
}
