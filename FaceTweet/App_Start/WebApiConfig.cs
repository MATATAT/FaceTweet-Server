using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FaceTweet
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "FaceTweetApi",
                routeTemplate: "facetweet/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
