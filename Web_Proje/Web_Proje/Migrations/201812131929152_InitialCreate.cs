namespace Web_Proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        PostHead = c.String(nullable: false),
                        PostSubHead = c.String(nullable: false),
                        PostCategory = c.String(nullable: false),
                        PostContent = c.String(nullable: false),
                        Img = c.String(),
                    })
                .PrimaryKey(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Post");
        }
    }
}