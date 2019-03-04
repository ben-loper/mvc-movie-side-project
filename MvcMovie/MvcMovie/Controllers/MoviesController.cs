using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Database;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<MovieModel> movies = new List<MovieModel>();
            MovieDAL movieDAL = new MovieDAL();

            movies = movieDAL.GetMovies();

            return View(movies);
        }
    }
}