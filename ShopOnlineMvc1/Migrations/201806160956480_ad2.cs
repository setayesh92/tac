namespace ShopOnlineMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ad2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Production.Product", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("Production.Product", "CategoryId");
            AddForeignKey("Production.Product", "CategoryId", "Production.Category", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Production.Product", "CategoryId", "Production.Category");
            DropIndex("Production.Product", new[] { "CategoryId" });
            DropColumn("Production.Product", "CategoryId");
        }
    }
}
