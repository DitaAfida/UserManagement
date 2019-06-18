namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Application",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Application_Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Department_Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        District_Name = c.String(),
                        Regency_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Regency", t => t.Regency_Id, cascadeDelete: true)
                .Index(t => t.Regency_Id);
            
            CreateTable(
                "dbo.TB_M_Regency",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Regency_Name = c.String(),
                        Province_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Province", t => t.Province_Id, cascadeDelete: true)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.TB_M_Province",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Province_Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Employee_Name = c.String(),
                        Address = c.String(),
                        Gender = c.String(),
                        Marital_Status = c.String(),
                        Phone_Number = c.String(),
                        Joindate = c.DateTimeOffset(nullable: false, precision: 7),
                        Employment_status = c.String(),
                        Email = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Department_Id = c.Int(nullable: false),
                        Village_Id = c.Int(nullable: false),
                        Position_Id = c.Int(nullable: false),
                        Religion_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Department", t => t.Department_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Position", t => t.Position_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Religion", t => t.Religion_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Village", t => t.Village_Id, cascadeDelete: true)
                .Index(t => t.Department_Id)
                .Index(t => t.Village_Id)
                .Index(t => t.Position_Id)
                .Index(t => t.Religion_Id);
            
            CreateTable(
                "dbo.TB_M_Position",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position_Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Religion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Village",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Village_Name = c.String(),
                        District_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_District", t => t.District_Id, cascadeDelete: true)
                .Index(t => t.District_Id);
            
            CreateTable(
                "dbo.TB_M_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role_Name = c.String(),
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Application", t => t.Application_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Application_Id);
            
            CreateTable(
                "dbo.TB_M_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Employee_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Employee", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Employee_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Role", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Role_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_UserRole", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_UserRole", "Role_Id", "dbo.TB_M_Role");
            DropForeignKey("dbo.TB_T_UserApplication", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_User", "Employee_Id", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_T_UserApplication", "Application_Id", "dbo.TB_M_Application");
            DropForeignKey("dbo.TB_M_Employee", "Village_Id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Village", "District_Id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_Employee", "Religion_Id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_Employee", "Position_Id", "dbo.TB_M_Position");
            DropForeignKey("dbo.TB_M_Employee", "Department_Id", "dbo.TB_M_Department");
            DropForeignKey("dbo.TB_M_District", "Regency_Id", "dbo.TB_M_Regency");
            DropForeignKey("dbo.TB_M_Regency", "Province_Id", "dbo.TB_M_Province");
            DropIndex("dbo.TB_T_UserRole", new[] { "Role_Id" });
            DropIndex("dbo.TB_T_UserRole", new[] { "User_Id" });
            DropIndex("dbo.TB_M_User", new[] { "Employee_Id" });
            DropIndex("dbo.TB_T_UserApplication", new[] { "Application_Id" });
            DropIndex("dbo.TB_T_UserApplication", new[] { "User_Id" });
            DropIndex("dbo.TB_M_Village", new[] { "District_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "Religion_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "Position_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "Village_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "Department_Id" });
            DropIndex("dbo.TB_M_Regency", new[] { "Province_Id" });
            DropIndex("dbo.TB_M_District", new[] { "Regency_Id" });
            DropTable("dbo.TB_T_UserRole");
            DropTable("dbo.TB_M_User");
            DropTable("dbo.TB_T_UserApplication");
            DropTable("dbo.TB_M_Role");
            DropTable("dbo.TB_M_Village");
            DropTable("dbo.TB_M_Religion");
            DropTable("dbo.TB_M_Position");
            DropTable("dbo.TB_M_Employee");
            DropTable("dbo.TB_M_Province");
            DropTable("dbo.TB_M_Regency");
            DropTable("dbo.TB_M_District");
            DropTable("dbo.TB_M_Department");
            DropTable("dbo.TB_M_Application");
        }
    }
}
