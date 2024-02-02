namespace Tours_KS.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "UserId_Id", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserId_Id" });
            RenameColumn(table: "dbo.Orders", name: "UserId_Id", newName: "UserId");
            AlterColumn("dbo.Orders", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "User");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "User", c => c.String());
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserId" });
            AlterColumn("dbo.Orders", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Orders", name: "UserId", newName: "UserId_Id");
            CreateIndex("dbo.Orders", "UserId_Id");
            AddForeignKey("dbo.Orders", "UserId_Id", "dbo.Users", "Id");
        }
    }
}
