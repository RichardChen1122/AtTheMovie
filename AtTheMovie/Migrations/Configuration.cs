namespace AtTheMovie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtTheMovie.Models.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AtTheMovie.Models.MovieDbContext context)
        {
            context.Movies.AddOrUpdate(m => m.Title,
            new Models.Movie
            {
                Title = "Star War",
                ID = 1

            }, new Models.Movie
            {
                Title = "Inception",
                ID = 2
            });
        }
    }
}
