using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newProject.Controllers
{
    public class BlogPostController : Controller
    {
        // GET: BlogPost
        public ActionResult Index()
        {
            return View();
        }
    }
}