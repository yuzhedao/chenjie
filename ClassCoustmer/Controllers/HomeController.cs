using ClassCoustmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassCoustmer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(Users model)
        {
            UserLogin db = new UserLogin();
            if (db.About(model) == true)
            {
                return Redirect("/Home/Index");
            }
            return Content("用户名或密码错误!");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}