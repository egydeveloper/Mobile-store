namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiatecreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.accessierdetailes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        type = c.String(),
                        quantity = c.Int(nullable: false),
                        warranty = c.Double(nullable: false),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.accessierimages",
                c => new
                    {
                        id = c.Int(nullable: false),
                        nameproduct = c.String(nullable: false),
                        productimg1 = c.Binary(),
                        productimg2 = c.Binary(),
                        productimg3 = c.Binary(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.accessierdetailes", t => t.id)
                .Index(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.accessierimages", "id", "dbo.accessierdetailes");
            DropIndex("dbo.accessierimages", new[] { "id" });
            DropTable("dbo.accessierimages");
            DropTable("dbo.accessierdetailes");
        }
    }
}
