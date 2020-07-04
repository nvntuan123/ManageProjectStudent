namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StartYear = c.DateTime(nullable: false, storeType: "date"),
                        EndYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.CourseID);
            
            AddColumn("dbo.Class", "Course", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            CreateIndex("dbo.Class", "Course");
            AddForeignKey("dbo.Class", "Course", "dbo.Course", "CourseID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Class", "Course", "dbo.Course");
            DropIndex("dbo.Class", new[] { "Course" });
            DropColumn("dbo.Class", "Course");
            DropTable("dbo.Course");
        }
    }
}
