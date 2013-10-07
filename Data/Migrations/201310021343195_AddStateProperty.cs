namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStateProperty : DbMigration
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
