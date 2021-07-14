using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using _1811063611_NguyenHoangVinh_BigSchool.DTOs;
using _1811063611_NguyenHoangVinh_BigSchool.Models;
using Microsoft.AspNet.Identity;

namespace _1811063611_NguyenHoangVinh_BigSchool.Controllers
{
    /// chấm bài
    /// </summary>
    [Authorize]
    public class AttendancesController : ApiController
    {
        // GET: Attendances
        //public ActionResult Index()
        //{
        //    return View();
        //}
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            {
                return BadRequest("the Attendance already exists!!");
            }
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId,
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}