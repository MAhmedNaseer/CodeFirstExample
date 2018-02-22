namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        departmentId = c.Int(nullable: false, identity: true),
                        departmentDescription = c.String(),
                    })
                .PrimaryKey(t => t.departmentId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employeeId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        password = c.String(),
                        department_departmentId = c.Int(),
                    })
                .PrimaryKey(t => t.employeeId)
                .ForeignKey("dbo.Departments", t => t.department_departmentId)
                .Index(t => t.department_departmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "department_departmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "department_departmentId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
