using Models;
using Models.Dao;
using newProject.Areas.Admin.Common;
using newProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newProject.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.Username, Emcrytor.MD5Hash(model.Password));
                if (result==1)
                {
                    var user = dao.getUserName(model.Username);
                    var userSession = new UserLogin();
                    userSession.Username = user.Username;
                    userSession.MaThanhVien = user.MaThanhVien;
                    Session.Add(CommonConstants.USER_SESSION,userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if(result == -1)
                {
                    ModelState.AddModelError("","Đăng nhập không đúng");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Đăng nhập không tồn tại");
                }
            }
            return View("Index");
        }
    }
}