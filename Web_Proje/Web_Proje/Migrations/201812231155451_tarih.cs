namespace Web_Proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tarih : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "PostDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Post", "PostDate");
        }
    }
}
