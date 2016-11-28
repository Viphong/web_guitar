using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace newProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "BaiGiang",
               url: "baigiang/{metatitle}/{baigiangId}",
               defaults: new { controller = "Lesson", action = "ViewLessonType", id = UrlParameter.Optional },
               namespaces: new[] { "newProject.Controllers" }
           );
            routes.MapRoute(
                name: "Video",
                url: "videoDetail/{metatitle}/{videoId}",
                defaults: new { controller = "VideoPage", action = "VideoDetail", id = UrlParameter.Optional },
                namespaces: new[] { "newProject.Controllers" }
            );
            routes.MapRoute(
                name: "VideoByTunes",
                url: "video/{metatitle}/{TunesId}",
                defaults: new { controller = "VideoPage", action = "Tunes", id = UrlParameter.Optional },
                namespaces: new[] { "newProject.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "newProject.Controllers" }
            );
        }
    }
}
