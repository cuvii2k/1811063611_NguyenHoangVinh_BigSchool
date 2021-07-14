using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1811063611_NguyenHoangVinh_BigSchool.DTOs;
using _1811063611_NguyenHoangVinh_BigSchool.Models;
using Microsoft.AspNet.Identity;

namespace _1811063611_NguyenHoangVinh_BigSchool.Controllers.API
{
    public class UnFollowController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public UnFollowController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public IHttpActionResult UnFollow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();

            var FollowToDel = _dbContext
                .Followings
                .FirstOrDefault(c => c.FollowerId == userId && c.FolloweeId == followingDto.FolloweeId);
            if (FollowToDel == null)
            {
                return BadRequest("The Follow not exists !!");
            }
            _dbContext.Followings.Remove(FollowToDel);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
