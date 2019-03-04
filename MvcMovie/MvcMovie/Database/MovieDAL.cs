using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Database
{
    public class MovieDAL
    {
        private string _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DVDStore;Integrated Security=True";



        public List<MovieModel> GetMovies()
        {
            string _sqlGetAllMovies = "SELECT film.title, film.description, film.length, film.release_year, film.replacement_cost, film.rating, category.name FROM film JOIN film_category ON film_category.film_id = film.film_id JOIN category ON film_category.category_id = category.category_id;";

            List<MovieModel> movies = new List<MovieModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(_sqlGetAllMovies, conn);

                // execute command
                SqlDataReader reader = cmd.ExecuteReader();

                // if applicable loop through result set
                while (reader.Read())
                {
                    // populate object(s) to return
                    MovieModel m = new MovieModel();
                    m.Title = Convert.ToString(reader["title"]);
                    m.Length = Convert.ToInt32(reader["length"]);
                    m.Genre = Convert.ToString(reader["name"]);
                    m.Description = Convert.ToString(reader["description"]);
                    m.Price = Convert.ToDecimal(reader["replacement_cost"]);
                    m.ReleaseYear = Convert.ToInt32(reader["release_year"]);

                    movies.Add(m);
                }
            }

            return movies;
        }
    }
}
