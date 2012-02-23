using System.Collections.ObjectModel;

using NancyMovie.Models;

namespace NancyMovie.Tasks
{
    public interface IMoviesTasks
    {
        Collection<Movie> GetAll();

        void Save(Movie movie);

        Movie Get(int id);

        void Delete(Movie movie);
    }
}