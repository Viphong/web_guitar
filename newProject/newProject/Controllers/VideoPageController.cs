using Models.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace newProject.Controllers
{
    public class VideoPageController : Controller
    {
        // GET: VideoPage
        public ActionResult Index()
        {
            var VideoDao = new VideoDao();
            ViewBag.NewVideo = VideoDao.ListNewVideo(8);
            return View();
        }
       
        public ActionResult VideoDetail(long videoId)
        {
            var videodetail = new VideoDao().VideoDetail(videoId);
            return View(videodetail);
        }
        public ActionResult Tunes(long TunesId)
        {
            var tunes = new TunesDao().VideoByGiaiDieu(TunesId);
            ViewBag.Tunes = tunes;
            var model = new VideoDao().ListByTunes(TunesId);
            return View(model);
        }
      
        
    }
}