using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1811063611_NguyenHoangVinh_BigSchool.Models;

namespace _1811063611_NguyenHoangVinh_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}