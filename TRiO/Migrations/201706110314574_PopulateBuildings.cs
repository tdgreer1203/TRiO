namespace TRiO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBuildings : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Buildings (Name) VALUES ('Jackson Davis')");
            Sql("INSERT INTO Buildings (Name) VALUES ('Tucker Hall')");
            Sql("INSERT INTO Buildings (Name) VALUES ('SBI')");
            Sql("INSERT INTO Buildings (Name) VALUES ('Gaither Gym')");
            Sql("INSERT INTO Buildings (Name) VALUES ('TRiO')");
            Sql("INSERT INTO Buildings (Name) VALUES ('University Commons')");
            Sql("INSERT INTO Buildings (Name) VALUES ('Jones Hall')");
            Sql("INSERT INTO Buildings (Name) VALUES ('Gore Education Complex')");
        }
        
        public override void Down()
        {
        }
    }
}
