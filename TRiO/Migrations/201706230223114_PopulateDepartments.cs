namespace TRiO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartments : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departments (Name) VALUES ('Physics')");
            Sql("INSERT INTO Departments (Name) VALUES ('Math')");
            Sql("INSERT INTO Departments (Name) VALUES ('TRiO')");
        }
        
        public override void Down()
        {
        }
    }
}
