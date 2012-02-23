using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace NancyMovie.Models
{
    public class MovieListViewModel
    {
        public Collection<Movie> Movies { get; set; }
    }
}