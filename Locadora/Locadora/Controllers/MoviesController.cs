using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Locadora.Models;
namespace Locadora.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        DatabaseMovie Db;
        public MoviesController()
        {
            Db = new DatabaseMovie();
        }
        public ActionResult Index()
        {
            var Services = Db.Movies.ToList();
            return View(Services);
        }
        public ActionResult Create()
        {
            ViewBag.Movie = Db.Movies;
            var model = new Movies();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Movies model)
        {
            if (ModelState.IsValid)
            {
                var movie = new Movies();
                movie.Nome = model.Nome;

                Db.Movies.Add(movie);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.movies = Db.Movies;
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movies movie = Db.Movies.Find(id);
            if(movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.movies = Db.Movies;
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include ="Id, Nome")] Movies model)
        {
            if (ModelState.IsValid)
            {
                var movie = Db.Movies.Find(model.Id);
                if (movie == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                movie.Nome = model.Nome;
                movie.Id = model.Id;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Movies = Db.Movies;
            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            Movies movie = Db.Movies.Find(id);
            Db.Movies.Remove(movie);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movies movie = Db.Movies.Find(id);
            ViewBag.Movie = Db.Movies;
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }
    }
}
