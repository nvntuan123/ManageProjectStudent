namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        ProjectName = c.String(maxLength: 4000),
                        StartDay = c.DateTime(nullable: false, storeType: "date"),
                        EndDay = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.ResultProject",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StudentID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ProjectID, t.StudentID })
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.ProjectID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StudentName = c.String(maxLength: 100),
                        BirthDay = c.DateTime(nullable: false, storeType: "date"),
                        CardID = c.Int(nullable: false),
                        Email = c.String(maxLength: 200, unicode: false),
                        Address = c.String(maxLength: 4000),
                        StartYear = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResultProject", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ResultProject", "ProjectID", "dbo.Project");
            DropIndex("dbo.ResultProject", new[] { "StudentID" });
            DropIndex("dbo.ResultProject", new[] { "ProjectID" });
            DropTable("dbo.Student");
            DropTable("dbo.ResultProject");
            DropTable("dbo.Project");
        }
    }
}
