namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiatecreate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.mobildetailes", "total_price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.mobildetailes", "total_price", c => c.Double(nullable: false));
        }
    }
}
