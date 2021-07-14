using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _1811063611_NguyenHoangVinh_BigSchool.Models;

namespace _1811063611_NguyenHoangVinh_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        private readonly ApplicationDbContext _dbContext;
        public string dataSearch { get; set; } 
        public CoursesViewModel()
        {
            _dbContext = new ApplicationDbContext();
        }
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        public bool CheckFollowing(string followeeId, string userId)
        {
            var ListFollowing = _dbContext.Followings.Where(c => c.FollowerId == userId).ToList();
            foreach (var i in ListFollowing)
            {
                if (i.FolloweeId.Equals(followeeId))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckAttend(int courseId, string userId)
        {
            var listAttend = _dbContext.Attendances.Where(c => c.AttendeeId == userId).ToList();
            foreach(var i in listAttend)
            {
                if (i.CourseId == courseId)
                {
                    return true;
                }
            }
            return false;
        }

    }

    
}