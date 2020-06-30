namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamResult", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ResultProject", "StudentID", "dbo.Student");
            DropForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student");
            DropIndex("dbo.ExamResult", new[] { "StudentID" });
            DropIndex("dbo.ResultProject", new[] { "StudentID" });
            DropIndex("dbo.TeachAndStudy", new[] { "StudentID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.TeachAndStudy", "StudentID");
            CreateIndex("dbo.ResultProject", "StudentID");
            CreateIndex("dbo.ExamResult", "StudentID");
            AddForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.ResultProject", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.ExamResult", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
        }
    }
}
