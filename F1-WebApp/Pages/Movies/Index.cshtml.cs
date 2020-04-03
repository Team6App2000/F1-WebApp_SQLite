using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using F1_WebApp.Models;

namespace F1_WebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly F1_WebAppMovieContext _context;

        public IndexModel(F1_WebAppMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
