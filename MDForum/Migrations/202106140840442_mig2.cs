namespace MDForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Themes", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Themes", "CategoryId", c => c.Int(nullable: false));
        }
    }
}
