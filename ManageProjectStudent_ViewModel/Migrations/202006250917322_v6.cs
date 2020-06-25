namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" }, "dbo.ExamTimes");
            DropIndex("dbo.ExamResult", new[] { "SubjectID" });
            DropIndex("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" });
            DropColumn("dbo.ExamResult", "ExamTimesID");
            DropColumn("dbo.ExamResult", "SubjectID");
            RenameColumn(table: "dbo.ExamResult", name: "ExamTimesModel_StrExamTimesID", newName: "ExamTimesID");
            RenameColumn(table: "dbo.ExamResult", name: "ExamTimesModel_StrTrainingProgramID", newName: "TrainingProgramID");
            RenameColumn(table: "dbo.ExamResult", name: "ExamTimesModel_StrSubjectID", newName: "SubjectID");
            DropPrimaryKey("dbo.ExamResult");
            AlterColumn("dbo.ExamResult", "ExamTimesID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.ExamResult", "TrainingProgramID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.ExamResult", "SubjectID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.ExamResult", new[] { "ExamTimesID", "TrainingProgramID", "StudentID", "SubjectID" });
            CreateIndex("dbo.ExamResult", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" });
            AddForeignKey("dbo.ExamResult", "TrainingProgramID", "dbo.TrainingProgram", "TrainingProgramID", cascadeDelete: true);
            AddForeignKey("dbo.ExamResult", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" }, "dbo.ExamTimes", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamResult", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" }, "dbo.ExamTimes");
            DropForeignKey("dbo.ExamResult", "TrainingProgramID", "dbo.TrainingProgram");
            DropIndex("dbo.ExamResult", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" });
            DropPrimaryKey("dbo.ExamResult");
            AlterColumn("dbo.ExamResult", "SubjectID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.ExamResult", "TrainingProgramID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.ExamResult", "ExamTimesID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.ExamResult", new[] { "ExamTimesID", "StudentID", "SubjectID" });
            RenameColumn(table: "dbo.ExamResult", name: "SubjectID", newName: "ExamTimesModel_StrSubjectID");
            RenameColumn(table: "dbo.ExamResult", name: "TrainingProgramID", newName: "ExamTimesModel_StrTrainingProgramID");
            RenameColumn(table: "dbo.ExamResult", name: "ExamTimesID", newName: "ExamTimesModel_StrExamTimesID");
            AddColumn("dbo.ExamResult", "SubjectID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            CreateIndex("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" });
            CreateIndex("dbo.ExamResult", "SubjectID");
            AddForeignKey("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" }, "dbo.ExamTimes", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" });
        }
    }
}
