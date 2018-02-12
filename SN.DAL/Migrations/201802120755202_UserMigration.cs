namespace SN.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "IsOnline", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Messages", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUsers", "ApplicationUser_Id");
            AddForeignKey("dbo.AspNetUsers", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Messages", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Messages", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "ApplicationUser_Id");
            DropColumn("dbo.AspNetUsers", "IsOnline");
            DropColumn("dbo.Messages", "ApplicationUser_Id");
        }
    }
}
