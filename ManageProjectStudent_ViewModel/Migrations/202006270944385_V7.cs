namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V7 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ExamResult");
            CreateTable(
                "dbo.ExamTimes",
                c => new
                    {
                        ExamTimesID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Times = c.Int(nullable: false),
                        ExamTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExamTimesID);
            
            AddColumn("dbo.ExamResult", "ExamTimesID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.ExamResult", new[] { "StudentID", "ExamTimesID", "SubjectID" });
            CreateIndex("dbo.ExamResult", "ExamTimesID");
            AddForeignKey("dbo.ExamResult", "ExamTimesID", "dbo.ExamTimes", "ExamTimesID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamResult", "ExamTimesID", "dbo.ExamTimes");
            DropIndex("dbo.ExamResult", new[] { "ExamTimesID" });
            DropPrimaryKey("dbo.ExamResult");
            DropColumn("dbo.ExamResult", "ExamTimesID");
            DropTable("dbo.ExamTimes");
            AddPrimaryKey("dbo.ExamResult", new[] { "StudentID", "SubjectID" });
        }
    }
}
