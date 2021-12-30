using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDTO newRental)
        {
            //no movie id
            if (newRental.MoviesId.Count == 0)
            {
                return BadRequest("There Is No Movie IDs have been Given.");
            }

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            //no customer id
            if (customer == null)
            {
                return BadRequest("Customer ID Is Not valid.");
            }

            var movies = _context.Movies.Where(m => newRental.MoviesId.Contains(m.Id)).ToList();
            //one of movie id is not valid
            if (movies.Count != newRental.MoviesId.Count)
            {
                return BadRequest("One Or More Movie IDs is Invalid.");
            }

            foreach (var movie in movies)
            {
                //no movie available
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie Is Not Available");
                }
                else if (movie.NumberAvailable > 0)
                {
                    var rental = new Rental
                    {
                        Customer = customer,
                        Movie = movie,
                        DateRented = DateTime.Now
                    };
                     
                    movie.NumberAvailable--;
                    
                    _context.Rentals.Add(rental);
                }
            }
            _context.SaveChanges();
            return Ok();
        }

    }
}