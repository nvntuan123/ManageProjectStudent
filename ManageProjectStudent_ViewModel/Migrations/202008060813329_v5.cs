namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Decentralize", "FormID", "dbo.Form");
            DropPrimaryKey("dbo.Form");
            DropPrimaryKey("dbo.Language_Word");
            AddColumn("dbo.Language", "Ordering", c => c.Int(nullable: false));
            AddColumn("dbo.Language_Word", "ID", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.Form", "FormID", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddPrimaryKey("dbo.Form", "FormID");
            AddPrimaryKey("dbo.Language_Word", new[] { "ID", "LanguageID", "WordID" });
            AddForeignKey("dbo.Decentralize", "FormID", "dbo.Form", "FormID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Decentralize", "FormID", "dbo.Form");
            DropPrimaryKey("dbo.Language_Word");
            DropPrimaryKey("dbo.Form");
            AlterColumn("dbo.Form", "FormID", c => c.String(nullable: false, maxLength: 10, unicode: false));
            DropColumn("dbo.Language_Word", "ID");
            DropColumn("dbo.Language", "Ordering");
            AddPrimaryKey("dbo.Language_Word", new[] { "LanguageID", "WordID" });
            AddPrimaryKey("dbo.Form", "FormID");
            AddForeignKey("dbo.Decentralize", "FormID", "dbo.Form", "FormID", cascadeDelete: true);
        }
    }
}
