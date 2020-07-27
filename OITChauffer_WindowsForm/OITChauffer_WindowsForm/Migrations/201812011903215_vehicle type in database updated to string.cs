namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vehicletypeindatabaseupdatedtostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chauffers", "VehicleType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chauffers", "VehicleType", c => c.Int(nullable: false));
        }
    }
}
