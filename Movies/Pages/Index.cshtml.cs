using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Movies.Pages
{
    public class IndexModel : PageModel
    {

        /// <summary>
        /// The movies to display on the index page 
        /// </summary>
        public IEnumerable<Movie> Movies { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] MPAARatings { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] IMDBMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] IMDBMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] TomatoesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] TomatoesMax { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet()
        {
            Movies = MovieDatabase.All;
            // Search movie titles for the SearchTerms
            if (SearchTerms != null)
            {
                Movies = from movie in Movies
                         where movie.Title != null && movie.Title.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                         select movie;
            }
            // Filter by MPAA Rating 
            if (MPAARatings != null && MPAARatings.Length != 0)
            {
                Movies = Movies.Where(movie =>
                movie.MPAARating != null && 
                MPAARatings.Contains(movie.MPAARating)
                );
            }
        }
    }
}
