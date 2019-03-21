namespace DepartmentWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialFillDepartments : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departments (Title) VALUES ('IT Department')");
            Sql("INSERT INTO Departments (Title) VALUES ('Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
