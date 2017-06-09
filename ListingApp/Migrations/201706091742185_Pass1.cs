namespace ListingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pass1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductName", c => c.String());
            AddColumn("dbo.Products", "Condition", c => c.String());
            AddColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Image");
            DropColumn("dbo.Products", "Condition");
            DropColumn("dbo.Products", "ProductName");
        }
    }
}
