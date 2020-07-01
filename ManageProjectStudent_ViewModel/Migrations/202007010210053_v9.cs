namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staff", "CardID", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Student", "CardID", c => c.String(maxLength: 8000, unicode: false));
            CreateIndex("dbo.ExamResult", "StudentID");
            CreateIndex("dbo.ResultProject", "StudentID");
            CreateIndex("dbo.TeachAndStudy", "StudentID");
            AddForeignKey("dbo.ExamResult", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.ResultProject", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ResultProject", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ExamResult", "StudentID", "dbo.Student");
            DropIndex("dbo.TeachAndStudy", new[] { "StudentID" });
            DropIndex("dbo.ResultProject", new[] { "StudentID" });
            DropIndex("dbo.ExamResult", new[] { "StudentID" });
            AlterColumn("dbo.Student", "CardID", c => c.Int(nullable: false));
            AlterColumn("dbo.Staff", "CardID", c => c.Int(nullable: false));
        }
    }
}
