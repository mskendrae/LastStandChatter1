namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtimeagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "timeStamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "timeStamp");
        }
    }
}
