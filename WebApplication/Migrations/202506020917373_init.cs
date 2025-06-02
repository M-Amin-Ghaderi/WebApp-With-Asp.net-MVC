namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Name = c.String(nullable: false, maxLength: 20),
                        Product_Details = c.String(nullable: false, maxLength: 100),
                        Product_Price = c.String(nullable: false),
                        Product_Image = c.String(),
                        Product_UserId = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        Phone = c.String(),
                        password = c.String(),
                        Email = c.String(),
                        Register_date = c.DateTime(nullable: false),
                        gender = c.Boolean(),
                        IsActive = c.Boolean(nullable: false),
                        UserRole_Id = c.Int(nullable: false),
                        Role_Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Role_Id)
                .Index(t => t.Role_Role_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Role_Id = c.Int(nullable: false, identity: true),
                        Role_Name = c.String(),
                        Role_Title = c.String(),
                    })
                .PrimaryKey(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Products", "Users_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "Role_Role_Id" });
            DropIndex("dbo.Products", new[] { "Users_Id" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
        }
    }
}
