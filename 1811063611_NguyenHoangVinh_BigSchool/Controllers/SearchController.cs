using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1811063611_NguyenHoangVinh_BigSchool.Models;
using _1811063611_NguyenHoangVinh_BigSchool.ViewModels;

namespace _1811063611_NguyenHoangVinh_BigSchool.Controllers
{
  
    public class SearchController : Controller
    {  
        private  ApplicationDbContext _dbContext;
        // GET: Search
        public SearchController()
        {
            _dbContext = new ApplicationDbContext();
        }
            public ActionResult Index(string search)
            {
                if (string.IsNullOrEmpty(search))
                {
                    return RedirectToAction("Index", "Home");
                }
                var upcommingCourses = _dbContext.Courses
                    .Include(s => s.Lecturer)
                    .Include(s => s.Category)
                    .Where(s =>
                    s.Lecturer.Name.Contains(search) &&
                    s.DateTime > DateTime.Now &&
                    s.IsCanceled == false);
                var viewModel = new CoursesViewModel
                {
                    UpcommingCourses = upcommingCourses,
                    ShowAction = User.Identity.IsAuthenticated,
                    dataSearch = search,
                };
                return View(viewModel);
            } 
    }
}