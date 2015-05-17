namespace NewsApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "View", c => c.Int(nullable: false));
            AddColumn("dbo.Articles", "Thumbnail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "Thumbnail");
            DropColumn("dbo.Articles", "View");
        }
    }
}
