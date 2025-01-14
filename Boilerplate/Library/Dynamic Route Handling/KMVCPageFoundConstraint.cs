﻿using CMS.DocumentEngine;
using CMS.EventLog;
using CMS.Helpers;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using RequestContext = System.Web.Routing.RequestContext;
namespace KMVCHelper
{
    public class KMVCPageFoundConstraint : IRouteConstraint
    {
        public bool IgnoreRootPage;

        public KMVCPageFoundConstraint(bool IgnoreRootPage = true)
        {
            this.IgnoreRootPage = IgnoreRootPage;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            // If no document found anyway, then it will always be a match
            TreeNode FoundDoc = DocumentQueryHelper.GetNodeByAliasPath(httpContext.Request.Url.AbsolutePath);
            return (FoundDoc != null && (FoundDoc.NodeAliasPath != "/" || !IgnoreRootPage));
        }

    }
}