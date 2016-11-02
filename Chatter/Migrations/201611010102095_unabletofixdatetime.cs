namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unabletofixdatetime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "Timestamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Timestamp", c => c.DateTime(nullable: false));
        }
    }
}
