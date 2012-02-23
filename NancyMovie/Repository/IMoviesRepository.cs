using System.Collections.ObjectModel;

using NancyMovie.Models;

namespace NancyMovie.Repository
{
    public interface IMoviesRepository
    {
        Collection<Movie> GetAll();

        void Save(Movie movie);

        Movie Get(int id);

        void Delete(Movie movie);
    }
}