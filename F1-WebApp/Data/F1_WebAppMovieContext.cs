using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using F1_WebApp.Models;

    public class F1_WebAppMovieContext : DbContext
    {
        public F1_WebAppMovieContext (DbContextOptions<F1_WebAppMovieContext> options)
            : base(options)
        {
        }

        public DbSet<F1_WebApp.Models.Movie> Movie { get; set; }
    }
