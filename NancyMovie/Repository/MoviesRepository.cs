using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

using NancyMovie.Models;
using NancyMovie.Repository.Commands;

namespace NancyMovie.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly IMovieCommands movieCommands;

        public MoviesRepository(IMovieCommands movieCommands)
        {
            this.movieCommands = movieCommands;
        }

        public Collection<Movie> GetAll()
        {
            using (var context = new MoviesDbContext())
            {
                return movieCommands.GetAllMovies(context);
            }
        }

        public void Save(Movie movie)
        {
            using (var context = new MoviesDbContext())
            {
                movieCommands.SaveMovie(context, movie);
            }
        }

        public Movie Get(int id)
        {
            using (var context = new MoviesDbContext())
            {
                return movieCommands.GetMovie(context, id);
            }
        }

        public void Delete(Movie movie)
        {
            using (var context = new MoviesDbContext())
            {
                movieCommands.DeleteMovie(context, movie);
            }
        }
    }
}