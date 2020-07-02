namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" }, "dbo.ExamTimes");
            DropForeignKey("dbo.ExamTimes", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.ExamTimes", "TrainingProgramID", "dbo.TrainingProgram");
            DropIndex("dbo.Subject", new[] { "FacultyModel_StrFacultyID" });
            DropIndex("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" });
            DropIndex("dbo.ExamTimes", new[] { "TrainingProgramID" });
            DropIndex("dbo.ExamTimes", new[] { "SubjectID" });
            RenameColumn(table: "dbo.Subject", name: "FacultyID", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Project", name: "StaffModel_StrStaffID", newName: "StaffID");
            RenameColumn(table: "dbo.Project", name: "SubjectModel_StrSubjectID", newName: "SubjectID");
            RenameColumn(table: "dbo.Student", name: "ClassModel_StrClassID", newName: "ClassID");
            RenameColumn(table: "dbo.Student", name: "FacultyModel_StrFacultyID", newName: "FacultyID");
            RenameColumn(table: "dbo.Class", name: "FacultyModel_StrFacultyID", newName: "FacultyID");
            RenameColumn(table: "dbo.Staff", name: "FacultyModel_StrFacultyID", newName: "FacultyID");
            RenameColumn(table: "dbo.ClassGroupOfSubject", name: "StaffModel_StrStaffID", newName: "StaffID");
            RenameColumn(table: "dbo.Staff", name: "StaffTypeModel_StrStaffTypeID", newName: "StaffTypeID");
            RenameColumn(table: "dbo.ClassGroupOfSubject", name: "SubjectModel_StrSubjectID", newName: "SubjectID");
            RenameColumn(table: "dbo.Subject", name: "FacultyModel_StrFacultyID", newName: "FacultyID");
            RenameColumn(table: "dbo.Subject", name: "__mig_tmp__0", newName: "SubjectID");
            RenameIndex(table: "dbo.Project", name: "IX_StaffModel_StrStaffID", newName: "IX_StaffID");
            RenameIndex(table: "dbo.Project", name: "IX_SubjectModel_StrSubjectID", newName: "IX_SubjectID");
            RenameIndex(table: "dbo.Student", name: "IX_FacultyModel_StrFacultyID", newName: "IX_FacultyID");
            RenameIndex(table: "dbo.Student", name: "IX_ClassModel_StrClassID", newName: "IX_Class");
            RenameIndex(table: "dbo.Class", name: "IX_FacultyModel_StrFacultyID", newName: "IX_FacultyID");
            RenameIndex(table: "dbo.Staff", name: "IX_StaffTypeModel_StrStaffTypeID", newName: "IX_StaffTypeID");
            RenameIndex(table: "dbo.Staff", name: "IX_FacultyModel_StrFacultyID", newName: "IX_FacultyID");
            RenameIndex(table: "dbo.ClassGroupOfSubject", name: "IX_StaffModel_StrStaffID", newName: "IX_StaffID");
            RenameIndex(table: "dbo.ClassGroupOfSubject", name: "IX_SubjectModel_StrSubjectID", newName: "IX_SubjectID");
            DropPrimaryKey("dbo.ExamResult");
            AlterColumn("dbo.Subject", "FacultyID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.ExamResult", new[] { "StudentID", "SubjectID" });
            CreateIndex("dbo.Subject", "FacultyID");
            DropColumn("dbo.ExamResult", "ExamTimesID");
            DropColumn("dbo.ExamResult", "ExamTimesModel_StrExamTimesID");
            DropColumn("dbo.ExamResult", "ExamTimesModel_StrTrainingProgramID");
            DropColumn("dbo.ExamResult", "ExamTimesModel_StrSubjectID");
            DropTable("dbo.ExamTimes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ExamTimes",
                c => new
                    {
                        ExamTimesID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Times = c.Int(nullable: false),
                        ExamTime = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.ExamTimesID, t.TrainingProgramID, t.SubjectID });
            
            AddColumn("dbo.ExamResult", "ExamTimesModel_StrSubjectID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesModel_StrTrainingProgramID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesModel_StrExamTimesID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ExamResult", "ExamTimesID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            DropIndex("dbo.Subject", new[] { "FacultyID" });
            DropPrimaryKey("dbo.ExamResult");
            AlterColumn("dbo.Subject", "FacultyID", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.ExamResult", new[] { "ExamTimesID", "StudentID", "SubjectID" });
            RenameIndex(table: "dbo.ClassGroupOfSubject", name: "IX_SubjectID", newName: "IX_SubjectModel_StrSubjectID");
            RenameIndex(table: "dbo.ClassGroupOfSubject", name: "IX_StaffID", newName: "IX_StaffModel_StrStaffID");
            RenameIndex(table: "dbo.Staff", name: "IX_FacultyID", newName: "IX_FacultyModel_StrFacultyID");
            RenameIndex(table: "dbo.Staff", name: "IX_StaffTypeID", newName: "IX_StaffTypeModel_StrStaffTypeID");
            RenameIndex(table: "dbo.Class", name: "IX_FacultyID", newName: "IX_FacultyModel_StrFacultyID");
            RenameIndex(table: "dbo.Student", name: "IX_Class", newName: "IX_ClassModel_StrClassID");
            RenameIndex(table: "dbo.Student", name: "IX_FacultyID", newName: "IX_FacultyModel_StrFacultyID");
            RenameIndex(table: "dbo.Project", name: "IX_SubjectID", newName: "IX_SubjectModel_StrSubjectID");
            RenameIndex(table: "dbo.Project", name: "IX_StaffID", newName: "IX_StaffModel_StrStaffID");
            RenameColumn(table: "dbo.Subject", name: "SubjectID", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Subject", name: "FacultyID", newName: "FacultyModel_StrFacultyID");
            RenameColumn(table: "dbo.ClassGroupOfSubject", name: "SubjectID", newName: "SubjectModel_StrSubjectID");
            RenameColumn(table: "dbo.Staff", name: "StaffTypeID", newName: "StaffTypeModel_StrStaffTypeID");
            RenameColumn(table: "dbo.ClassGroupOfSubject", name: "StaffID", newName: "StaffModel_StrStaffID");
            RenameColumn(table: "dbo.Staff", name: "FacultyID", newName: "FacultyModel_StrFacultyID");
            RenameColumn(table: "dbo.Class", name: "FacultyID", newName: "FacultyModel_StrFacultyID");
            RenameColumn(table: "dbo.Student", name: "FacultyID", newName: "FacultyModel_StrFacultyID");
            RenameColumn(table: "dbo.Student", name: "ClassID", newName: "ClassModel_StrClassID");
            RenameColumn(table: "dbo.Project", name: "SubjectID", newName: "SubjectModel_StrSubjectID");
            RenameColumn(table: "dbo.Project", name: "StaffID", newName: "StaffModel_StrStaffID");
            RenameColumn(table: "dbo.Subject", name: "__mig_tmp__0", newName: "FacultyID");
            CreateIndex("dbo.ExamTimes", "SubjectID");
            CreateIndex("dbo.ExamTimes", "TrainingProgramID");
            CreateIndex("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" });
            CreateIndex("dbo.Subject", "FacultyModel_StrFacultyID");
            AddForeignKey("dbo.ExamTimes", "TrainingProgramID", "dbo.TrainingProgram", "TrainingProgramID", cascadeDelete: true);
            AddForeignKey("dbo.ExamTimes", "SubjectID", "dbo.Subject", "FacultyID", cascadeDelete: true);
            AddForeignKey("dbo.ExamResult", new[] { "ExamTimesModel_StrExamTimesID", "ExamTimesModel_StrTrainingProgramID", "ExamTimesModel_StrSubjectID" }, "dbo.ExamTimes", new[] { "ExamTimesID", "TrainingProgramID", "SubjectID" });
        }
    }
}
