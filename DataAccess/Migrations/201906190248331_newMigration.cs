namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_T_UserApplication", "Application_Id", "dbo.TB_M_Application");
            DropForeignKey("dbo.TB_T_UserApplication", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_UserRole", "Role_Id", "dbo.TB_M_Role");
            DropForeignKey("dbo.TB_T_UserRole", "User_Id", "dbo.TB_M_User");
            DropIndex("dbo.TB_T_UserApplication", new[] { "User_Id" });
            DropIndex("dbo.TB_T_UserApplication", new[] { "Application_Id" });
            DropIndex("dbo.TB_T_UserRole", new[] { "User_Id" });
            DropIndex("dbo.TB_T_UserRole", new[] { "Role_Id" });
            CreateTable(
                "dbo.UserAplications",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Aplication_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Aplication_Id })
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Application", t => t.Aplication_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Aplication_Id);
            
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.User_Id })
                .ForeignKey("dbo.TB_M_Role", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.User_Id);
            
            DropTable("dbo.TB_T_UserApplication");
            DropTable("dbo.TB_T_UserRole");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TB_T_UserRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_UserApplication",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Application_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.RoleUsers", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.RoleUsers", "Role_Id", "dbo.TB_M_Role");
            DropForeignKey("dbo.UserAplications", "Aplication_Id", "dbo.TB_M_Application");
            DropForeignKey("dbo.UserAplications", "User_Id", "dbo.TB_M_User");
            DropIndex("dbo.RoleUsers", new[] { "User_Id" });
            DropIndex("dbo.RoleUsers", new[] { "Role_Id" });
            DropIndex("dbo.UserAplications", new[] { "Aplication_Id" });
            DropIndex("dbo.UserAplications", new[] { "User_Id" });
            DropTable("dbo.RoleUsers");
            DropTable("dbo.UserAplications");
            CreateIndex("dbo.TB_T_UserRole", "Role_Id");
            CreateIndex("dbo.TB_T_UserRole", "User_Id");
            CreateIndex("dbo.TB_T_UserApplication", "Application_Id");
            CreateIndex("dbo.TB_T_UserApplication", "User_Id");
            AddForeignKey("dbo.TB_T_UserRole", "User_Id", "dbo.TB_M_User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_T_UserRole", "Role_Id", "dbo.TB_M_Role", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_T_UserApplication", "User_Id", "dbo.TB_M_User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_T_UserApplication", "Application_Id", "dbo.TB_M_Application", "Id", cascadeDelete: true);
        }
    }
}
