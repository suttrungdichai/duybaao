using lab3._4._5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3._4._5.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categoties { get; set; }
    }
}