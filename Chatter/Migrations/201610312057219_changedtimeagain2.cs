namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtimeagain2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "timeStamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "timeStamp", c => c.DateTime(nullable: false));
        }
    }
}
