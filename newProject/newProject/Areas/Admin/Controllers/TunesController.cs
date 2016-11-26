using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newProject.Areas.Admin.Controllers
{
    public class TunesController : Controller
    {
        // GET: Admin/Tunes
        public ActionResult Index()
        {
            var iplTunes = new TunesModel();
            var model = iplTunes.ListAll();
            return View(model);
        }

        // GET: Admin/Tunes/Details/
        [ValidateAntiForgeryToken]
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        // GET: Admin/Tunes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tunes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GiaiDieu collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new TunesModel();
                    int res = model.Create(collection.TenGiaiDieu, collection.MoTa);
                    if(res>0)
                    
                        // TODO: Add insert logic here
                        return RedirectToAction("Index");
                    
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công");
                    }
                    
                }
                return View(collection);
              

            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Tunes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Tunes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Tunes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Tunes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
