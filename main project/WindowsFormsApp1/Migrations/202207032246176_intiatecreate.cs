namespace main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiatecreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Count = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Discount = c.Int(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Billaccessierdetailes",
                c => new
                    {
                        Bill_Id = c.Int(nullable: false),
                        accessierdetaile_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bill_Id, t.accessierdetaile_id })
                .ForeignKey("dbo.Bills", t => t.Bill_Id, cascadeDelete: true)
                .ForeignKey("dbo.accessierdetailes", t => t.accessierdetaile_id, cascadeDelete: true)
                .Index(t => t.Bill_Id)
                .Index(t => t.accessierdetaile_id);
            
            CreateTable(
                "dbo.mobildetaileBills",
                c => new
                    {
                        mobildetaile_id = c.Int(nullable: false),
                        Bill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.mobildetaile_id, t.Bill_Id })
                .ForeignKey("dbo.mobildetailes", t => t.mobildetaile_id, cascadeDelete: true)
                .ForeignKey("dbo.Bills", t => t.Bill_Id, cascadeDelete: true)
                .Index(t => t.mobildetaile_id)
                .Index(t => t.Bill_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mobildetaileBills", "Bill_Id", "dbo.Bills");
            DropForeignKey("dbo.mobildetaileBills", "mobildetaile_id", "dbo.mobildetailes");
            DropForeignKey("dbo.Bills", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Billaccessierdetailes", "accessierdetaile_id", "dbo.accessierdetailes");
            DropForeignKey("dbo.Billaccessierdetailes", "Bill_Id", "dbo.Bills");
            DropIndex("dbo.mobildetaileBills", new[] { "Bill_Id" });
            DropIndex("dbo.mobildetaileBills", new[] { "mobildetaile_id" });
            DropIndex("dbo.Billaccessierdetailes", new[] { "accessierdetaile_id" });
            DropIndex("dbo.Billaccessierdetailes", new[] { "Bill_Id" });
            DropIndex("dbo.Bills", new[] { "Customer_ID" });
            DropTable("dbo.mobildetaileBills");
            DropTable("dbo.Billaccessierdetailes");
            DropTable("dbo.Bills");
        }
    }
}
