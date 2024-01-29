namespace Tours_KS.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCountry : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tours", name: "Country_Code", newName: "CountryCode");
            RenameIndex(table: "dbo.Tours", name: "IX_Country_Code", newName: "IX_CountryCode");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tours", name: "IX_CountryCode", newName: "IX_Country_Code");
            RenameColumn(table: "dbo.Tours", name: "CountryCode", newName: "Country_Code");
        }
    }
}
