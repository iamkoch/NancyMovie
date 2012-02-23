using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

using Nancy;

using NancyMovie.Models;
using NancyMovie.Repository;
using NancyMovie.Tasks;

using Nancy.ModelBinding;

namespace NancyMovie.Controllers
{
    public class HomeModule : NancyModule
    {
        public HomeModule(IMoviesTasks moviesTasks)
            : base("/Home")
        {
            Get["/"] = parameters =>
            {
                var movieListViewModel = new MovieListViewModel { Movies = moviesTasks.GetAll() };
                return View["Index.cshtml", movieListViewModel];
            };

            Get["/Create"] = parameters =>
            { 
                return View["Create.cshtml"];
            };

            Post["/Create"] = parameters =>
            {
                var newMovie = this.Bind<Movie>();
                moviesTasks.Save(newMovie);

                var movieListViewModel = new MovieListViewModel { Movies = moviesTasks.GetAll() };
                return View["Index.cshtml", movieListViewModel];
            };

            Get["/Edit/{id}"] = parameters =>
            {
                var movie = moviesTasks.Get(parameters.id);
                return View["Edit.cshtml", movie];
            };

            Post["/Edit"] = parameters =>
            {
                var movie = this.Bind<Movie>();
                moviesTasks.Save(movie);

                var movieListViewModel = new MovieListViewModel { Movies = moviesTasks.GetAll() };
                return View["Index.cshtml", movieListViewModel];
            };

            Delete["/Delete/{id}"] = parameters =>
            {
                var movie = moviesTasks.Get(parameters.id);
                moviesTasks.Delete(movie);
                return 200;
            };
        }
    }
}