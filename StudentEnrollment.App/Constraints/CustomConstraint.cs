﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace StudentEnrollment.App.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, 
            Route route, 
            string parameterName, 
            RouteValueDictionary values, 
            RouteDirection routeDirection)
        {
            return true;
        }
    }
}
