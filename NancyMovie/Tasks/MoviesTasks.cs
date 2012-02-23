using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

using NancyMovie.Models;
using NancyMovie.Repository;

namespace NancyMovie.Tasks
{
    public class MoviesTasks : IMoviesTasks
    {
        private readonly IMoviesRepository moviesRepository;

        public MoviesTasks(IMoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public Collection<Movie> GetAll()
        {
            return moviesRepository.GetAll();
        }

        public void Save(Movie movie)
        {
            moviesRepository.Save(movie);
        }

        public Movie Get(int id)
        {
            return moviesRepository.Get(id);
        }

        public void Delete(Movie movie)
        {
            moviesRepository.Delete(movie);
        }
    }
}