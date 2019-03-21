namespace UserWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialFillUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Users (UserName, DepartmentId) VALUES ('Sam', 1)");
            Sql("INSERT INTO Users (UserName, DepartmentId) VALUES ('Alex', 2)");
            Sql("INSERT INTO Users (UserName, DepartmentId) VALUES ('Jane', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
