namespace TRiO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLabs : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Labs (Name, Room, BuildingId, DepartmentId) VALUES ('TRiO Computer Lab', '100', 5, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
