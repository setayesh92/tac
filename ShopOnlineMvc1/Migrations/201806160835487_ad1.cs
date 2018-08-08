namespace ShopOnlineMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ad1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "User.AddressUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressLocate = c.String(maxLength: 20),
                        NameOstan = c.String(nullable: false, maxLength: 20),
                        Namecity = c.String(nullable: false, maxLength: 20),
                        Descripton = c.String(maxLength: 50),
                        Telephone = c.String(nullable: false, maxLength: 11),
                        Mobile = c.String(nullable: false, maxLength: 11),
                        PostalCode = c.String(maxLength: 10),
                        UserUserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("User.User", t => t.UserUserName)
                .Index(t => t.UserUserName);
            
            CreateTable(
                "User.User",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Passworde = c.String(nullable: false, maxLength: 30),
                        FullName = c.String(nullable: false, maxLength: 30),
                        Rule = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "User.CommentUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductIdComment = c.Int(nullable: false),
                        Comment = c.String(maxLength: 50),
                        UserUserName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("User.User", t => t.UserUserName)
                .Index(t => t.UserUserName);
            
            CreateTable(
                "Buy.BuyFactor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.String(),
                        BuyDate = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StatuseFactor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Buy.BuyProduct",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyProductId = c.Int(nullable: false),
                        BuyName = c.String(maxLength: 30),
                        BuyNumber = c.Int(nullable: false),
                        BuyTechnique = c.String(maxLength: 25),
                        SizeBoard = c.String(maxLength: 20),
                        FirstPrice = c.Double(nullable: false),
                        Reduction = c.Double(nullable: false),
                        LastPrice = c.Double(nullable: false),
                        PaikName = c.String(),
                        FactorId = c.Int(nullable: false),
                        Description = c.String(maxLength: 80),
                        Statuse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.DetailProductCarpet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfRidger = c.Int(nullable: false),
                        DemensionsTocm = c.String(),
                        TypeOfTissue = c.String(),
                        Genus = c.String(),
                        Clips = c.Double(nullable: false),
                        Knot = c.Double(nullable: false),
                        Color = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Production.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameBoard = c.String(nullable: false, maxLength: 50),
                        FirstPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reduction = c.Double(nullable: false),
                        LastPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAvailable = c.Boolean(nullable: false),
                        Number = c.Int(nullable: false),
                        TimeGaranty = c.Int(nullable: false),
                        UrlImage = c.String(maxLength: 150),
                        NameArtist = c.String(maxLength: 30),
                        SizeBoard = c.String(maxLength: 20),
                        Technique = c.String(maxLength: 25),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("User.CommentUser", "UserUserName", "User.User");
            DropForeignKey("User.AddressUser", "UserUserName", "User.User");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("User.CommentUser", new[] { "UserUserName" });
            DropIndex("User.AddressUser", new[] { "UserUserName" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("Production.Product");
            DropTable("Production.DetailProductCarpet");
            DropTable("Production.Category");
            DropTable("Buy.BuyProduct");
            DropTable("Buy.BuyFactor");
            DropTable("User.CommentUser");
            DropTable("User.User");
            DropTable("User.AddressUser");
        }
    }
}
