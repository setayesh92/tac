namespace ShopOnlineMvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productlist1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("Production.Product", "IsAvailable");
        }
        
        public override void Down()
        {
            AddColumn("Production.Product", "IsAvailable", c => c.Boolean(nullable: false));
        }
    }
}
