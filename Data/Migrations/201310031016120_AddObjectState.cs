namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddObjectState : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PersonAddresses", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonAddresses", "State", c => c.String());
        }
    }
}
