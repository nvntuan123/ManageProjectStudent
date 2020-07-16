namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v13 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Language",
                c => new
                    {
                        LanguageID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        LanguageName = c.String(maxLength: 100),
                        Default = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageID);
            
            CreateTable(
                "dbo.Language_Word",
                c => new
                    {
                        LanguageID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        WordID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Mean = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.LanguageID, t.WordID })
                .ForeignKey("dbo.Language", t => t.LanguageID, cascadeDelete: true)
                .ForeignKey("dbo.Word", t => t.WordID, cascadeDelete: true)
                .Index(t => t.LanguageID)
                .Index(t => t.WordID);
            
            CreateTable(
                "dbo.Word",
                c => new
                    {
                        WordID = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        WordName = c.String(maxLength: 100),
                        Module = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.WordID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Language_Word", "WordID", "dbo.Word");
            DropForeignKey("dbo.Language_Word", "LanguageID", "dbo.Language");
            DropIndex("dbo.Language_Word", new[] { "WordID" });
            DropIndex("dbo.Language_Word", new[] { "LanguageID" });
            DropTable("dbo.Word");
            DropTable("dbo.Language_Word");
            DropTable("dbo.Language");
        }
    }
}
