using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Proje.DAL;
using Web_Proje.Models;

namespace Web_Proje.Controllers
{
    public class HomeController : Controller
    {
        private PostContext db = new PostContext(); 
        public ActionResult Index()
        {
            return View(db.Post.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Haberler(int id)
        {
            Post Posts = new Post();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Posts = db.Post.Find(id);
            if (Posts == null)
            {
                return HttpNotFound();
            }
            return View(Posts);
        }
        public ActionResult Spor()
        {
            return View(db.Post.ToList());
        }
        public ActionResult Ekonomi()
        {
            return View(db.Post.ToList());
        }
        public ActionResult Siyaset()
        {
            return View(db.Post.ToList());
        }
        public ActionResult Magazin()
        {
            return View(db.Post.ToList());
        }
    }
}