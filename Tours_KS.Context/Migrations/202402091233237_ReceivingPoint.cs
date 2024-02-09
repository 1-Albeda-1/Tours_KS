namespace Tours_KS.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReceivingPoint : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReceivingPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "ReceivingPointId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderCode", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "ReceivingPointId");
            AddForeignKey("dbo.Orders", "ReceivingPointId", "dbo.ReceivingPoints", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ReceivingPointId", "dbo.ReceivingPoints");
            DropIndex("dbo.Orders", new[] { "ReceivingPointId" });
            DropColumn("dbo.Orders", "OrderCode");
            DropColumn("dbo.Orders", "ReceivingPointId");
            DropTable("dbo.ReceivingPoints");
        }
    }
}
