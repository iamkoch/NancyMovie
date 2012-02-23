using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

using NancyMovie.Models;

namespace NancyMovie.Repository.Commands
{
    public interface IMovieCommands
    {
        Collection<Movie> GetAllMovies(IMoviesDbContext context);

        void SaveMovie(MoviesDbContext context, Movie movie);

        Movie GetMovie(MoviesDbContext context, int id);

        void DeleteMovie(MoviesDbContext context, Movie movie);
    }
}