namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp1.entitystore>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WindowsFormsApp1.entitystore";
        }

        protected override void Seed(WindowsFormsApp1.entitystore context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
