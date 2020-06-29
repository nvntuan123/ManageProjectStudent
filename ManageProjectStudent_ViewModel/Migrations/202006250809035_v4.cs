namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentClassGroup",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        GroupID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.StudentID, t.GroupID })
                .ForeignKey("dbo.ClassGroupOfSubject", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        FacultyID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        FacultyName = c.String(maxLength: 100),
                        FoundedYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.FacultyID);
            
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ClassID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        ClassName = c.String(maxLength: 10),
                        FacultyModel_StrFacultyID = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.ClassID)
                .ForeignKey("dbo.Faculty", t => t.FacultyModel_StrFacultyID)
                .Index(t => t.FacultyModel_StrFacultyID);
            
            CreateTable(
                "dbo.SubjectAssignment",
                c => new
                    {
                        TrainingProgramID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        FacultyID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Semester = c.String(maxLength: 4000),
                        SchoolYear = c.DateTime(nullable: false, storeType: "date"),
                        Credits = c.Int(nullable: false),
                        TheoreticalLesson = c.Int(nullable: false),
                        PracticalLesson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TrainingProgramID, t.FacultyID, t.SubjectID })
                .ForeignKey("dbo.Faculty", t => t.FacultyID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.FacultyID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.TeachAndStudy",
                c => new
                    {
                        StaffID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StudentID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SubjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Semester = c.String(maxLength: 100),
                        SchoolYear = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.StaffID, t.StudentID, t.SubjectID })
                .ForeignKey("dbo.Staff", t => t.StaffID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StaffID)
                .Index(t => t.SubjectID);
            
            AddColumn("dbo.Staff", "FacultyModel_StrFacultyID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.ClassGroupOfSubject", "SubjectModel_StrSubjectID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AddColumn("dbo.Subject", "FacultyModel_StrFacultyID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            CreateIndex("dbo.Staff", "FacultyModel_StrFacultyID");
            CreateIndex("dbo.ClassGroupOfSubject", "SubjectModel_StrSubjectID");
            CreateIndex("dbo.Subject", "FacultyModel_StrFacultyID");
            AddForeignKey("dbo.ClassGroupOfSubject", "SubjectModel_StrSubjectID", "dbo.Subject", "FacultyID");
            AddForeignKey("dbo.Staff", "FacultyModel_StrFacultyID", "dbo.Faculty", "FacultyID");
            AddForeignKey("dbo.Subject", "FacultyModel_StrFacultyID", "dbo.Faculty", "FacultyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeachAndStudy", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.TeachAndStudy", "StaffID", "dbo.Staff");
            DropForeignKey("dbo.Subject", "FacultyModel_StrFacultyID", "dbo.Faculty");
            DropForeignKey("dbo.SubjectAssignment", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.SubjectAssignment", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.Staff", "FacultyModel_StrFacultyID", "dbo.Faculty");
            DropForeignKey("dbo.Class", "FacultyModel_StrFacultyID", "dbo.Faculty");
            DropForeignKey("dbo.ClassGroupOfSubject", "SubjectModel_StrSubjectID", "dbo.Subject");
            DropForeignKey("dbo.StudentClassGroup", "GroupID", "dbo.ClassGroupOfSubject");
            DropIndex("dbo.TeachAndStudy", new[] { "SubjectID" });
            DropIndex("dbo.TeachAndStudy", new[] { "StaffID" });
            DropIndex("dbo.SubjectAssignment", new[] { "SubjectID" });
            DropIndex("dbo.SubjectAssignment", new[] { "FacultyID" });
            DropIndex("dbo.Class", new[] { "FacultyModel_StrFacultyID" });
            DropIndex("dbo.Subject", new[] { "FacultyModel_StrFacultyID" });
            DropIndex("dbo.StudentClassGroup", new[] { "GroupID" });
            DropIndex("dbo.ClassGroupOfSubject", new[] { "SubjectModel_StrSubjectID" });
            DropIndex("dbo.Staff", new[] { "FacultyModel_StrFacultyID" });
            DropColumn("dbo.Subject", "FacultyModel_StrFacultyID");
            DropColumn("dbo.ClassGroupOfSubject", "SubjectModel_StrSubjectID");
            DropColumn("dbo.Staff", "FacultyModel_StrFacultyID");
            DropTable("dbo.TeachAndStudy");
            DropTable("dbo.SubjectAssignment");
            DropTable("dbo.Class");
            DropTable("dbo.Faculty");
            DropTable("dbo.StudentClassGroup");
        }
    }
}
