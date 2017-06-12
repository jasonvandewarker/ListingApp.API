namespace ListingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pass2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Messages", name: "User_UserId", newName: "UserId");
            RenameIndex(table: "dbo.Messages", name: "IX_User_UserId", newName: "IX_UserId");
            AddColumn("dbo.Messages", "ToUserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "ToUserId");
            RenameIndex(table: "dbo.Messages", name: "IX_UserId", newName: "IX_User_UserId");
            RenameColumn(table: "dbo.Messages", name: "UserId", newName: "User_UserId");
        }
    }
}
