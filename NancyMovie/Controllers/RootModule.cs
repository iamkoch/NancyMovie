using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Responses;

namespace NancyMovie.Controllers
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            Get["/"] = parameters =>
            {
                return new RedirectResponse("/Home");
            };
        }
    }
}