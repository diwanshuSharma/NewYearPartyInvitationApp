namespace NewYearPartyInvitation.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewYearPartyInvitation.Models.DataAccess.GuestInfoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "NewYearPartyInvitation.Models.DataAccess.GuestInfoDBContext";
        }

        protected override void Seed(NewYearPartyInvitation.Models.DataAccess.GuestInfoDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
