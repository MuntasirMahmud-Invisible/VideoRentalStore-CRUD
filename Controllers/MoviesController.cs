using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VideoRentalApps.Models;
using VideoRentalApps.ViewModels;

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
        [Authorize(Roles = RoleName.CanManageMovies)]
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
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                movie.NumberAvailable = movie.NumberInStock;
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
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnLyList");
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

            var viewModel = new MovieFormViewModel(movie)
            {
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