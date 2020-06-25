namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassGroupOfSubject",
                c => new
                    {
                        GroupID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        GroupName = c.String(maxLength: 100),
                        StaffModel_StrStaffID = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.GroupID)
                .ForeignKey("dbo.Staff", t => t.StaffModel_StrStaffID)
                .Index(t => t.StaffModel_StrStaffID);
            
            CreateTable(
                "dbo.StaffType",
                c => new
                    {
                        StaffTypeID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StaffTypeName = c.String(maxLength: 100, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.StaffTypeID);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        FacultyID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SubjectName = c.String(maxLength: 100),
                        StartDay = c.DateTime(nullable: false, storeType: "date"),
                        EndDay = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.ExamResult",
                c => new
                    {
                        ExamTimesID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StudentID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ExamTimesID, t.TrainingProgramID, t.StudentID, t.SubjectID })
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.ExamTimes",
                c => new
                    {
                        ExamTimeID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Times = c.Int(nullable: false),
                        ExamTime = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.ExamTimeID, t.TrainingProgramID, t.SubjectID })
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID);
            
            AddColumn("dbo.Project", "SubjectModel_StrSubjectID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.Staff", "StaffTypeModel_StrStaffTypeID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            CreateIndex("dbo.Project", "SubjectModel_StrSubjectID");
            CreateIndex("dbo.Staff", "StaffTypeModel_StrStaffTypeID");
            AddForeignKey("dbo.Staff", "StaffTypeModel_StrStaffTypeID", "dbo.StaffType", "StaffTypeID");
            AddForeignKey("dbo.Project", "SubjectModel_StrSubjectID", "dbo.Subject", "FacultyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "SubjectModel_StrSubjectID", "dbo.Subject");
            DropForeignKey("dbo.ExamTimes", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.ExamResult", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Staff", "StaffTypeModel_StrStaffTypeID", "dbo.StaffType");
            DropForeignKey("dbo.ClassGroupOfSubject", "StaffModel_StrStaffID", "dbo.Staff");
            DropIndex("dbo.ExamTimes", new[] { "SubjectID" });
            DropIndex("dbo.ExamResult", new[] { "SubjectID" });
            DropIndex("dbo.ClassGroupOfSubject", new[] { "StaffModel_StrStaffID" });
            DropIndex("dbo.Staff", new[] { "StaffTypeModel_StrStaffTypeID" });
            DropIndex("dbo.Project", new[] { "SubjectModel_StrSubjectID" });
            DropColumn("dbo.Staff", "StaffTypeModel_StrStaffTypeID");
            DropColumn("dbo.Project", "SubjectModel_StrSubjectID");
            DropTable("dbo.ExamTimes");
            DropTable("dbo.ExamResult");
            DropTable("dbo.Subject");
            DropTable("dbo.StaffType");
            DropTable("dbo.ClassGroupOfSubject");
        }
    }
}
