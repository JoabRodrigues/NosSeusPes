namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NosSeusPes.ModelNosSeusPes>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NosSeusPes.ModelNosSeusPes context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Cores.AddOrUpdate(x => x.Id,
                new Cor() { Id = 1, Nome = "Branco" },
                new Cor() { Id = 2, Nome = "Preto" },
                new Cor() { Id = 3, Nome = "Amarelo" }
                );
        }
    }
}
