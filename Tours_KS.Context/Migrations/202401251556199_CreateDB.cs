namespace Tours_KS.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountOfStars = c.Int(nullable: false),
                        CountryCode = c.String(maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryCode)
                .Index(t => t.CountryCode);
            
            CreateTable(
                "dbo.HotelComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        Text = c.String(),
                        Author = c.String(),
                        CreationDate = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.HotelImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        ImageSource = c.Binary(),
                        ImageType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketCount = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ImagePreview = c.Binary(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActual = c.Boolean(nullable: false),
                        Country_Code = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Code)
                .Index(t => t.Country_Code);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTimeOffset(nullable: false, precision: 7),
                        AllSale = c.Short(nullable: false),
                        UserId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId_Id)
                .Index(t => t.UserId_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        RoleType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TourHotels",
                c => new
                    {
                        Tour_Id = c.Int(nullable: false),
                        Hotel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tour_Id, t.Hotel_Id })
                .ForeignKey("dbo.Tours", t => t.Tour_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .Index(t => t.Tour_Id)
                .Index(t => t.Hotel_Id);
            
            CreateTable(
                "dbo.OrderTours",
                c => new
                    {
                        Order_Id = c.Int(nullable: false),
                        Tour_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_Id, t.Tour_Id })
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.Tour_Id, cascadeDelete: true)
                .Index(t => t.Order_Id)
                .Index(t => t.Tour_Id);
            
            CreateTable(
                "dbo.TypeTours",
                c => new
                    {
                        Type_Id = c.Int(nullable: false),
                        Tour_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Type_Id, t.Tour_Id })
                .ForeignKey("dbo.Types", t => t.Type_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.Tour_Id, cascadeDelete: true)
                .Index(t => t.Type_Id)
                .Index(t => t.Tour_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tours", "Country_Code", "dbo.Countries");
            DropForeignKey("dbo.TypeTours", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.TypeTours", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Orders", "UserId_Id", "dbo.Users");
            DropForeignKey("dbo.OrderTours", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.OrderTours", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.TourHotels", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.TourHotels", "Tour_Id", "dbo.Tours");
            DropForeignKey("dbo.HotelImages", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.HotelComments", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "CountryCode", "dbo.Countries");
            DropIndex("dbo.TypeTours", new[] { "Tour_Id" });
            DropIndex("dbo.TypeTours", new[] { "Type_Id" });
            DropIndex("dbo.OrderTours", new[] { "Tour_Id" });
            DropIndex("dbo.OrderTours", new[] { "Order_Id" });
            DropIndex("dbo.TourHotels", new[] { "Hotel_Id" });
            DropIndex("dbo.TourHotels", new[] { "Tour_Id" });
            DropIndex("dbo.Orders", new[] { "UserId_Id" });
            DropIndex("dbo.Tours", new[] { "Country_Code" });
            DropIndex("dbo.HotelImages", new[] { "HotelId" });
            DropIndex("dbo.HotelComments", new[] { "HotelId" });
            DropIndex("dbo.Hotels", new[] { "CountryCode" });
            DropTable("dbo.TypeTours");
            DropTable("dbo.OrderTours");
            DropTable("dbo.TourHotels");
            DropTable("dbo.Types");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Tours");
            DropTable("dbo.HotelImages");
            DropTable("dbo.HotelComments");
            DropTable("dbo.Hotels");
            DropTable("dbo.Countries");
        }
    }
}
