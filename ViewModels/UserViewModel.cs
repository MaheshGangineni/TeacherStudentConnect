using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeacherStudentConnect.Models;

namespace TeacherStudentConnect.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public IEnumerable<SelectListItem> SubjectList
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem { Text = "Marketing", Value = "Marketing" },
                    new SelectListItem { Text = "International Relations", Value = "International Relations" },
                    new SelectListItem { Text = "Human Resources Management", Value = "Human Resources Management" },
                    new SelectListItem { Text = "Commerce", Value = "Commerce" },
                    new SelectListItem { Text = "Economics", Value = "Economics" },
                    new SelectListItem { Text = "Bookkeeping", Value = "Bookkeeping" },
                    new SelectListItem { Text = "Accounting", Value = "Accounting" },
                    new SelectListItem { Text = "Banking & Finance", Value = "Banking & Finance" },
                    new SelectListItem { Text = "Business Administration and Management", Value = "Business Administration and Management" },
                    new SelectListItem { Text = "Entrepreneurship", Value = "Entrepreneurship" },
                    new SelectListItem { Text = "Digital & Social Media Marketing", Value = "Digital & Social Media Marketing" },
                    new SelectListItem { Text = "Business Communication", Value = "Business Communication" },
                    new SelectListItem { Text = "Foreign Exchange Trading", Value = "Foreign Exchange Trading" },
                };
            }
            set
            {

            }
        }

        //public IEnumerable<SelectListItem> CategoryList
        //{
        //    get
        //    {
        //        return new List<SelectListItem>
        //                {
        //                new SelectListItem{Text="Teacher",Value="Teacher"},
        //                new SelectListItem{Text="Student",Value="Student"},
        //                };
        //    }
        //    set
        //    {

        //    }
        //}
    }

 }
        