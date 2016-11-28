using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newProject.Controllers
{
    public class LessonController : Controller
    {
        // GET: Lesson
        public ActionResult Index()
        {
            var model = new LessonDao().ListAllLesson();
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult ViewLesson()
        {
            var model = new LessonDao().Listlesson();
            return PartialView(model);
        }
        public ActionResult ViewLessonType(long baigiangId)
        {
            var model = new LessonDao().Listlesson();
            return PartialView(model);
        }
       
    }
}