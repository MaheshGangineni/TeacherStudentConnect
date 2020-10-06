using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeacherStudentConnect.ViewModels
{
    public class AdminLoginViewModel
    {
        [Required]
        [DisplayName("Admin Id")]
        public String AdminId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}