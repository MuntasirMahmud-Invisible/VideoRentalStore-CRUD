using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VideoRentalApps.Migrations;
using System.Web.Mvc;
using VideoRentalApps.Models;
using VideoRentalApps.ViewModels;
using System.Data.Entity.Validation;

namespace VideoRentalApps.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //Add: New Movie
        public ActionResult New()
        {
            var Genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = Genres,
            };
            return View("MovieForm", viewModel);
        }

        //Save
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;

            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        // GET: Movies
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }
       
        //Edit Movie
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }

    }
}
/*To Find The Exception Movie Save Controller*/
/*try
{
    _context.SaveChanges();
}
catch (DbEntityValidationException dbEx)
{
    foreach (var validationErrors in dbEx.EntityValidationErrors)
    {
        foreach (var validationError in validationErrors.ValidationErrors)
        {
            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
        }
    }
}*/