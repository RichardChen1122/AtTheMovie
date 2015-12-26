using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtTheMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}