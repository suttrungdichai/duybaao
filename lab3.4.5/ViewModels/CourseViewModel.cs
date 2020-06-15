using lab3._4._5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace lab3._4._5.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        //public int CategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        public class ValidTime : ValidationAttribute
        {
            

            public override bool IsValid(object value)
            {
                DateTime dateTime;
                var isValid = DateTime.TryParseExact(Convert.ToString(value),
                    "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
                
                return  isValid;
               
            }
        }

    }
    
}