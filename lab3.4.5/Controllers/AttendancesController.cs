using lab3._4._5.DTOs;
using lab3._4._5.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace lab3._4._5.Controllers
{
    [Authorize]

    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
      private AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendance.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("the ateendance alredy exists");
            var ateendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = User.Identity.GetUserId()
            };
            _dbContext.Attendance.Add(ateendance);
            _dbContext.SaveChanges();
            return Ok();
        }
       
    }
   
}
