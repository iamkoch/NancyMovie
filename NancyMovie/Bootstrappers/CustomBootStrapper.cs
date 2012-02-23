using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Conventions;

namespace NancyMovie.Bootstrappers
{
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("Scripts", @"Scripts")
            );

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("Styles", @"Styles")
            );
        }
    }
}