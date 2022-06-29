namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiatcreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.mobildetailes", "name", c => c.String(nullable: false));
            AlterColumn("dbo.mobile_images", "nameproduct", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.mobile_images", "nameproduct", c => c.String());
            AlterColumn("dbo.mobildetailes", "name", c => c.String());
        }
    }
}
