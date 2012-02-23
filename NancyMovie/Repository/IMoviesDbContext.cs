using System.Data.Entity;

using NancyMovie.Models;

namespace NancyMovie.Repository
{
    public interface IMoviesDbContext
    {
        IDbSet<Movie> Movies { get; set; }
    }
}