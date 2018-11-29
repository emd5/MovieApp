using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
       

        public List<Movie> Movies;
        public SelectList Genres;
        public SelectList Titles;
        public string MovieGenre { get; set; }
        public string MovieTitle { get; set; }
        public string SearchString { get; set; }

    }
}
