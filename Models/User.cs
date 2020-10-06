using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeacherStudentConnect.Models
{
    public class User:Subject 
    {
        [Required]
        [DisplayName("First Name")]
        [RegularExpression(@"^[A-Za-z\s?]{1,}$", ErrorMessage = "First Name is not in required format")]
        public String FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [RegularExpression(@"^[A-Za-z\s?]{1,}$", ErrorMessage = "Last Name is not in required format")]
        public String LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public String Gender { get; set; }

        [Required]
        [DisplayName("Mobile Number")]
        [RegularExpression(@"^[9876]{1}[0-9]{9}$", ErrorMessage = "Mobile Number is not in required format")]
        public long ContactNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Key]
        [Required]
        [DisplayName("User Id")]
        [RegularExpression(@"[a-z0-9_-]{3,}", ErrorMessage = "User Id is not in required format")]
        public String UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Password is not in required format")]
        public String Password { get; set; }

        //[FileExtensions(Extensions = ".jpg,.png,.jpeg")]
        //public string ImagePath { get; set; }

        //[Required]
        //[Display(Name = "Supported Files .png | .jpg")]
        //[AllowExtensions(Extensions = "png,jpg", ErrorMessage = "Please select only Supported Files .png | .jpg")]
        //public HttpPostedFileBase FileAttach { get; set; }
        //[AllowHtml]
        //[Required]
        //public byte[] Image { get; set; }

        [Required]
        public string Category { get; set; }


        public string Subject { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Joining")]
        public DateTime? DateOfJoining { get; set; }

        [DisplayName("Prior Experience (in months)")]
        public int PriorExperience { get; set; }

        [DisplayName("Experience (in months)")]
        public int Experience { get; set; }

        public string BatchNumber { get; set; }

        //public IEnumerable<SelectListItem> CategoryList
        //{
        //    get
        //    {
        //        return new List<SelectListItem>()
        //             {
        //                new SelectListItem { Text = "Admin", Value = "Admin" },
        //                new SelectListItem { Text = "Teacher", Value = "Teacher" },
        //                new SelectListItem { Text = "Student", Value = "Student" },
        //             };
        //    }
        //    set
        //    {

        //    }
        //}

    }
    }