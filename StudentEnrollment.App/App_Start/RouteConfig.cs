using StudentEnrollment.App.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace StudentEnrollment.App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {                       

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            var constraintResolver = new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap.Add("simple", typeof(CustomConstraint));
            routes.MapMvcAttributeRoutes(constraintResolver);
            routes.MapRoute(
                name: "About Specifc",
                url: "{action}",
                defaults: new { Controller = "Home", action = "About" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
