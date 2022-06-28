namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiatcreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.mobildetailes", "android", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.mobildetailes", "android", c => c.Double(nullable: false));
        }
    }
}
