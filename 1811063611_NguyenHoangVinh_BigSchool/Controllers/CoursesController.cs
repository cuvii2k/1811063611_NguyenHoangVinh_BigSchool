﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1811063611_NguyenHoangVinh_BigSchool.Models;
using _1811063611_NguyenHoangVinh_BigSchool.ViewModels;
using Microsoft.AspNet.Identity;

namespace _1811063611_NguyenHoangVinh_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        //hehe vinh
        // GET: Courses
        // update 4/7/21
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {

           var viewModel = new CourseViewModel
           {
             Categories = _dbContext.Categories.ToList()
           };
           return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerID = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place,
            };  
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}