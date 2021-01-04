namespace NewYearPartyInvitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuestInfoes",
                c => new
                    {
                        GuestInfoID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Age = c.Int(nullable: false),
                        CovidTestStatus = c.String(),
                    })
                .PrimaryKey(t => t.GuestInfoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GuestInfoes");
        }
    }
}
