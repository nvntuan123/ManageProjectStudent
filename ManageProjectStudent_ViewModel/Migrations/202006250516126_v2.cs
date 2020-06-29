namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectTask",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TaskID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TaskName = c.String(maxLength: 100),
                        StartDay = c.DateTime(nullable: false, storeType: "date"),
                        EndDay = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.ProjectID, t.TaskID })
                .ForeignKey("dbo.Project", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        StaffName = c.String(maxLength: 100),
                        CardID = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false, storeType: "date"),
                        Email = c.String(maxLength: 200, unicode: false),
                        Address = c.String(maxLength: 4000),
                        Phone = c.String(maxLength: 30, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID);
            
            AddColumn("dbo.Project", "StaffModel_StrStaffID", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            CreateIndex("dbo.Project", "StaffModel_StrStaffID");
            AddForeignKey("dbo.Project", "StaffModel_StrStaffID", "dbo.Staff", "StaffID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "StaffModel_StrStaffID", "dbo.Staff");
            DropForeignKey("dbo.ProjectTask", "ProjectID", "dbo.Project");
            DropIndex("dbo.ProjectTask", new[] { "ProjectID" });
            DropIndex("dbo.Project", new[] { "StaffModel_StrStaffID" });
            DropColumn("dbo.Project", "StaffModel_StrStaffID");
            DropTable("dbo.Staff");
            DropTable("dbo.ProjectTask");
        }
    }
}
