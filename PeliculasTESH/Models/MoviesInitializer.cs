using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PeliculasTESH.Models
{
    public class MoviesInitializer : DropCreateDatabaseAlways<MoviesDB>
    {
        protected override void Seed(MoviesDB context)
        {
            base.Seed(context);
            var movies = new List<Peliculas>            {                new Peliculas
                {                    Title = "Kill Bill",                    Director = "Quentin Tarantino",                    Duration = 150,                    Classification = "R"                }            };
            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
        }
    }
}