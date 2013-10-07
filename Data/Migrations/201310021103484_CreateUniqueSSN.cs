namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUniqueSSN : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "SSN", c => c.String(nullable: false, maxLength: 9));
            CreateIndex("dbo.Person", "SSN", unique: true, name: "UQ_SSN");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "SSN", c => c.String());
        }
    }
}
