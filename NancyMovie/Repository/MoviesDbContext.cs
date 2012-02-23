using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.EntityClient;
using System.Linq;
using System.Web;

using NancyMovie.Models;

namespace NancyMovie.Repository
{
    public class MoviesDbContext : DbContext, IMoviesDbContext
    {
        public MoviesDbContext()
            : this("name=MoviesContext")
        {
        }

        public MoviesDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public IDbSet<Movie> Movies { get; set; }
    }
}