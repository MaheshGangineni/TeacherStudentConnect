using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeacherStudentConnect.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("User Id")]
        public String UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}