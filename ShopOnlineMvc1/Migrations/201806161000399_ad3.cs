namespace ShopOnlineMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ad3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Production.Product", "CategoryId", "Production.Category");
            DropIndex("Production.Product", new[] { "CategoryId" });
            AlterColumn("Production.Product", "CategoryId", c => c.Int());
            CreateIndex("Production.Product", "CategoryId");
            AddForeignKey("Production.Product", "CategoryId", "Production.Category", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Production.Product", "CategoryId", "Production.Category");
            DropIndex("Production.Product", new[] { "CategoryId" });
            AlterColumn("Production.Product", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("Production.Product", "CategoryId");
            AddForeignKey("Production.Product", "CategoryId", "Production.Category", "Id", cascadeDelete: true);
        }
    }
}
