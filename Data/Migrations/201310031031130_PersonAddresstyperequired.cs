namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonAddresstyperequired : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonAddresses", "AddressType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonAddresses", "AddressType");
        }
    }
}
