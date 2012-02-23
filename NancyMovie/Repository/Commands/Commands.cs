using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Web;

using NancyMovie.Models;

namespace NancyMovie.Repository.Commands
{
    public class Commands : IMovieCommands
    {
        public Collection<Movie> GetAllMovies(IMoviesDbContext context)
        {
            return new Collection<Movie>(context.Movies.ToList());
        }

        public void SaveMovie(MoviesDbContext context, Movie movie)
        {
            if (movie.Id <= 0)
            {
                context.Entry(movie).State = EntityState.Added;
            }
            else
            {
                context.Entry(movie).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public Movie GetMovie(MoviesDbContext context, int id)
        {
            return context.Movies.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void DeleteMovie(MoviesDbContext context, Movie movie)
        {
            context.Entry(movie).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}