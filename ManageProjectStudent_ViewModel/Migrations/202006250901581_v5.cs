namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ExamTimes", name: "ExamTimeID", newName: "ExamTimesID");
            DropPrimaryKey("dbo.ExamResult");
            CreateTable(
                "dbo.TrainingProgram",
                c => new
                    {
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TrainingProgramName = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.TrainingProgramID);
            
            AddColumn("dbo.Student", "FacultyModel_StrFacultyID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.Student", "ClassModel_StrClassID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesModel_StrExamTimesID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesModel_StrTrainingProgramID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesModel_StrSubjectID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.ExamResult", new[] { "ExamTimesID", "StudentID", "SubjectID" });
            CreateIndex("dbo.Student", "FacultyModel_StrFacultyID");
            CreateIndex("dbo.Student", "ClassModel_StrClassID");
            CreateIndex("dbo.StudentClassGroup", "StudentID");
            CreateIndex("dbo.ExamResult", "StudentID");
            CreateIndex("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" });
            CreateIndex("dbo.ExamTimes", "TrainingProgramID");
            CreateIndex("dbo.SubjectAssignment", "TrainingProgramID");
            CreateIndex("dbo.TeachAndStudy", "StudentID");
            AddForeignKey("dbo.StudentClassGroup", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" }, "dbo.ExamTimes", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" });
            AddForeignKey("dbo.ExamTimes", "TrainingProgramID", "dbo.TrainingProgram", "TrainingProgramID", cascadeDelete: true);
            AddForeignKey("dbo.SubjectAssignment", "TrainingProgramID", "dbo.TrainingProgram", "TrainingProgramID", cascadeDelete: true);
            AddForeignKey("dbo.ExamResult", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student", "StudentID", cascadeDelete: true);
            AddForeignKey("dbo.Student", "FacultyModel_StrFacultyID", "dbo.Faculty", "FacultyID");
            AddForeignKey("dbo.Student", "ClassModel_StrClassID", "dbo.Class", "ClassID");
            DropColumn("dbo.ExamResult", "TrainingProgramID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExamResult", "TrainingProgramID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            DropForeignKey("dbo.Student", "ClassModel_StrClassID", "dbo.Class");
            DropForeignKey("dbo.Student", "FacultyModel_StrFacultyID", "dbo.Faculty");
            DropForeignKey("dbo.TeachAndStudy", "StudentID", "dbo.Student");
            DropForeignKey("dbo.ExamResult", "StudentID", "dbo.Student");
            DropForeignKey("dbo.SubjectAssignment", "TrainingProgramID", "dbo.TrainingProgram");
            DropForeignKey("dbo.ExamTimes", "TrainingProgramID", "dbo.TrainingProgram");
            DropForeignKey("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" }, "dbo.ExamTimes");
            DropForeignKey("dbo.StudentClassGroup", "StudentID", "dbo.Student");
            DropIndex("dbo.TeachAndStudy", new[] { "StudentID" });
            DropIndex("dbo.SubjectAssignment", new[] { "TrainingProgramID" });
            DropIndex("dbo.ExamTimes", new[] { "TrainingProgramID" });
            DropIndex("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" });
            DropIndex("dbo.ExamResult", new[] { "StudentID" });
            DropIndex("dbo.StudentClassGroup", new[] { "StudentID" });
            DropIndex("dbo.Student", new[] { "ClassModel_StrClassID" });
            DropIndex("dbo.Student", new[] { "FacultyModel_StrFacultyID" });
            DropPrimaryKey("dbo.ExamResult");
            DropColumn("dbo.ExamResult", "ExamTimesModel_StrSubjectID");
            DropColumn("dbo.ExamResult", "ExamTimesModel_StrTrainingProgramID");
            DropColumn("dbo.ExamResult", "ExamTimesModel_StrExamTimesID");
            DropColumn("dbo.Student", "ClassModel_StrClassID");
            DropColumn("dbo.Student", "FacultyModel_StrFacultyID");
            DropTable("dbo.TrainingProgram");
            AddPrimaryKey("dbo.ExamResult", new[] { "ExamTimesID", "TrainingProgramID", "StudentID", "SubjectID" });
            RenameColumn(table: "dbo.ExamTimes", name: "ExamTimesID", newName: "ExamTimeID");
        }
    }
}
