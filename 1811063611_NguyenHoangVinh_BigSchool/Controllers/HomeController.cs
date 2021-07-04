using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1811063611_NguyenHoangVinh_BigSchool.Models;
using System.Data.Entity;

namespace _1811063611_NguyenHoangVinh_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c=>c.DateTime > DateTime.Now);
            return View(upcommingCourses);
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
        private ApplicationDbContext _dbContext;
        public HomeController()

        {
            _dbContext = new ApplicationDbContext();
        }

    }

}