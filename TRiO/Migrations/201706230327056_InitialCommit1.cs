namespace TRiO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCommit1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        StudentId = c.Int(nullable: false),
                        LabId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Labs", t => t.LabId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.LabId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Sessions", "LabId", "dbo.Labs");
            DropIndex("dbo.Sessions", new[] { "LabId" });
            DropIndex("dbo.Sessions", new[] { "StudentId" });
            DropTable("dbo.Sessions");
        }
    }
}
