using MyBlogService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Post> posts;
            using (var db = _context)
            {
                posts =  db.Posts.ToList();
            }

            return View(posts);
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


        private BlogServiceDbContext _context;

        public HomeController()
        {
            _context = new BlogServiceDbContext();
        }
    }
}