using Models;
using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var VideoDao = new VideoDao();
            ViewBag.NewVideo = VideoDao.ListNewVideo(5);
            var model = new LessonDao();
            ViewBag.NewLesson = model.ListAllLesson();
            return View();
           
        }
        [ChildActionOnly]
        public ActionResult MainSliderPartial()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult tunesCategory()
        {
            var iplTunes = new TunesModel();
            var model = iplTunes.ListAll();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult TunesMenu()
        {
            var tunesName = new TunesModel();
            var model = tunesName.ListTunesName();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult BlogMenu()
        {
            var BlogType = new BlogDao();
            var model = BlogType.ListNameBlog();
            return PartialView(model);
        }
    }
}