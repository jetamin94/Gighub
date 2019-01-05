namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EFDemo.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var teams = DummyData.GetTeams();

            context.Teams.AddOrUpdate(t => new
            {
                t.Name,
                t.City
            }, teams.ToArray());


            var players = DummyData.GetPlayers();
            context.Players.AddOrUpdate(t => new
            {
                t.Name,
                t.Dob
            }, players.ToArray());
            context.SaveChanges();
        }
    }
}
