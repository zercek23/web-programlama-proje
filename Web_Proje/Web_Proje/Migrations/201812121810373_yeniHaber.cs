namespace Web_Proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yeniHaber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Post", "PostHead", c => c.String(nullable: false));
            AlterColumn("dbo.Post", "PostSubHead", c => c.String(nullable: false));
            AlterColumn("dbo.Post", "PostContent", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Post", "PostContent", c => c.String());
            AlterColumn("dbo.Post", "PostSubHead", c => c.String());
            AlterColumn("dbo.Post", "PostHead", c => c.String());
        }
    }
}
