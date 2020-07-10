namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectTask", "FileName", c => c.String(maxLength: 100));
            AddColumn("dbo.ProjectTask", "LinkFile", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectTask", "LinkFile");
            DropColumn("dbo.ProjectTask", "FileName");
        }
    }
}
