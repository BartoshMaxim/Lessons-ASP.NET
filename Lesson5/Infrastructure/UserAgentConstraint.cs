﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Lesson5.Infrastructure
{
    public class UserAgentConstraint : IRouteConstraint
    {
        private string _requiredUserAgent;

        public UserAgentConstraint(string requiredUserAgent)
        {
            _requiredUserAgent = requiredUserAgent;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent != null &&
                httpContext.Request.UserAgent.Contains(_requiredUserAgent);
        }
    }
}