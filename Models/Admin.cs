using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeacherStudentConnect.Models
{
    public class Admin
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
        [DisplayName("Admin Id")]
        public String AdminId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Password is not in required format")]
        public String Password { get; set; }

        [Required]
        public string Category { get; set; }

        [DisplayName("Admin Profile Status")]
        public string AdminProfileStatus { get; set; }

        public static readonly string Pending = "Pending";
        public static readonly string Approved = "Approved";
        public static readonly string Rejected = "Rejected";
    }
}