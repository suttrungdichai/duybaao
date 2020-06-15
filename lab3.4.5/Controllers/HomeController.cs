﻿using lab3._4._5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using lab3._4._5.ViewModels;

namespace lab3._4._5.Controllers
{
    public class HomeController : Controller
    {
        private  ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCoureses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category);
             //   .Include(c => c.DateTime > DateTime.Now);
            var viewModel = new CourseViewModel
            {
                UpcommingCourses = upcommingCoureses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
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
    }
}