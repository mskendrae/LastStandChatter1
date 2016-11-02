namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messagedatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "TimeStamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "TimeStamp");
        }
    }
}
