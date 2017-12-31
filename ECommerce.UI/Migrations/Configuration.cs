namespace ECommerce.UI.Migrations
{
    using ECommerce.UI.Entity;
    using ECommerce.UI.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerce.UI.Identity.IdentityDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ECommerce.UI.Identity.IdentityDataContext context)
        {
            Database.SetInitializer(new IdentityInitializer());
            Database.SetInitializer(new DataInitializer());

        }
    }
}
