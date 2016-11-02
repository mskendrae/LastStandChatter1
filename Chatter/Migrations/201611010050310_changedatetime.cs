namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Timestamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "Timestamp");
        }
    }
}
