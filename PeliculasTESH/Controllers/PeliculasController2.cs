using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PeliculasTESH.Models;

namespace PeliculasTESH.Controllers
{
    public class PeliculasController2 : Controller
    {
        MoviesDB db = new MoviesDB();
        public ActionResult Index()
        {
            
            return View(db.Movies.ToList());
        }
        public ActionResult Details(int Id)
        {
            Peliculas pelicula = db.Movies.Find(Id);
            if (pelicula == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(pelicula);
            }
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Peliculas pelicula)
        {
            db.Movies.Add(pelicula);
            db.SaveChanges();
            return RedirectToRoute("Index");
        }
    }
}