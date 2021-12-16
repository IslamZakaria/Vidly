using AutoMapper;
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
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET api/movie
        public IHttpActionResult GetMovie()
        {
            return Ok(_context.Movies.ToList().Select(Mapper.Map<Movie, MovieDTO>));
        }

        //GET api/movie/1
        public IHttpActionResult GetMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Movie, MovieDTO>(movieInDb));
        }

        //POST api/movie
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDTO MovieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movie = Mapper.Map<MovieDTO, Movie>(MovieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            MovieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), MovieDto);
        }

        //PUT api/movie/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDTO MovieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
            {
                return NotFound();
            }

            Mapper.Map(MovieDto, movieInDb);
            _context.SaveChanges();

            return Ok();
        }

        //DELETE api/movie/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDB == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movieInDB);
            _context.SaveChanges();
            return Ok();
        }
    }
}