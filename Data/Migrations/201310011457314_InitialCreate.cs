namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleInitial = c.String(),
                        Gender = c.Int(),
                        Citizenship = c.Int(),
                        SSN = c.String(),
                        UserAdded = c.String(),
                        DateAdded = c.DateTime(),
                        UserEdited = c.String(),
                        DateEdited = c.DateTime(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.PersonAddresses",
                c => new
                    {
                        PersonAddressID = c.Int(nullable: false, identity: true),
                        StreetNumber = c.String(),
                        StreetName = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                        UserAdded = c.String(),
                        DateAdded = c.DateTime(),
                        UserEdited = c.String(),
                        DateEdited = c.DateTime(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonAddressID)
                .ForeignKey("dbo.Person", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PersonAddresses", new[] { "Person_PersonID" });
            DropForeignKey("dbo.PersonAddresses", "Person_PersonID", "dbo.Person");
            DropTable("dbo.PersonAddresses");
            DropTable("dbo.Person");
        }
    }
}
