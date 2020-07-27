namespace OITChauffer_WindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertedlastmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payments", "PaymentType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Payments", "PaymentType", c => c.String(nullable: false));
        }
    }
}
