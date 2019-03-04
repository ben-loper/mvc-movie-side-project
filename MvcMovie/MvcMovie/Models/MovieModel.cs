using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieModel
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string rating { get; set; }
        public int ReleaseYear { get; set; }
    }
}
