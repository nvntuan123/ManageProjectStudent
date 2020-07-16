namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Decentralize",
                c => new
                    {
                        FormID = c.String(nullable: false, maxLength: 100, unicode: false),
                        StaffTypeID = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        FullFunction = c.Boolean(name: "Full Function", nullable: false),
                        Add = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        Access = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FormID);
            
            AddColumn("dbo.StaffType", "DecentralizeModel_StrFrmID", c => c.String(maxLength: 100, unicode: false));
            CreateIndex("dbo.StaffType", "DecentralizeModel_StrFrmID");
            AddForeignKey("dbo.StaffType", "DecentralizeModel_StrFrmID", "dbo.Decentralize", "FormID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffType", "DecentralizeModel_StrFrmID", "dbo.Decentralize");
            DropIndex("dbo.StaffType", new[] { "DecentralizeModel_StrFrmID" });
            DropColumn("dbo.StaffType", "DecentralizeModel_StrFrmID");
            DropTable("dbo.Decentralize");
        }
    }
}
