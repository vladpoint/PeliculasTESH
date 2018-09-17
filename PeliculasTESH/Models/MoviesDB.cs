using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PeliculasTESH.Models
{
    public class MoviesDB : DbContext
    {
        public DbSet<Peliculas> Movies {get; set;}
    }
}