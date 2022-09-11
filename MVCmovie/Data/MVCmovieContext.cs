using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCmovie.Models;

namespace MVCmovie.Data
{
    public class MVCmovieContext : DbContext
    {
        public MVCmovieContext (DbContextOptions<MVCmovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVCmovie.Models.Movie> Movie { get; set; } = default!;
    }
}
