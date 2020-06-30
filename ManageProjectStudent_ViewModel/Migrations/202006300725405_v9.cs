namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class v9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staff", "Sex", c => c.String(maxLength: 10));
            AddColumn("dbo.Student", "Sex", c => c.String(maxLength: 10));
            AddColumn("dbo.Student", "Phone", c => c.String(maxLength: 30, fixedLength: true, unicode: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Student", "Phone");
            DropColumn("dbo.Student", "Sex");
            DropColumn("dbo.Staff", "Sex");
        }
    }
}
