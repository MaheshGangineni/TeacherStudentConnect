using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeacherStudentConnect.Models
{
    public class SuperAdmin
    {
        [Key]
        [DisplayName("Super Admin Id")]
        [RegularExpression(@"[a-z0-9_-]{3,16}", ErrorMessage = "Super Admin Id is not in reuired format")]
        public string SuperAdminId { get; set; }

        [Required(ErrorMessage = "*Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}", ErrorMessage = "Password is not in required format")]
        public string Password { get; set; }
    }
}