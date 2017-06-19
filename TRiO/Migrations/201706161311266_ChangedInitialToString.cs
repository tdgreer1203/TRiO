namespace TRiO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedInitialToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "MiddleInitial", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "MiddleInitial");
        }
    }
}
