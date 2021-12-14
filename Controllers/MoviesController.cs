using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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
        // GET: Movie
        public ActionResult Random()
        {
            var movies = new List<Movie>() 
            { 
                new Movie {Id = 1, Name = "Sherk!" }, 
                new Movie {Id = 2, Name = "Wall-e" } 
            };
            
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movies
            };
            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }
       
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        public ActionResult New ()
        {
            var genre = _context.Genres.ToList();
            var ViewModel = new MovieFormViewModel
            {
                Genres= genre
            };

            return View("MovieForm", ViewModel);
        }

        [HttpPost]
        public ActionResult Save (Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAddedToDatabase = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDB = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDB.Name = movie.Name;
                movieInDB.ReleaseDate = movie.ReleaseDate;
                movieInDB.Genre = movie.Genre;
                movieInDB.NumberInStock = movie.NumberInStock;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var modelView = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList(),
                Movie = movie
            };
            return View("MovieForm", modelView);
        }
    }
}