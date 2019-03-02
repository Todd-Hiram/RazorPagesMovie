using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class RazorPagesMovieContext : DbContext
    {
            public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {

        }

        protected RazorPagesMovieContext()
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
