using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeacherStudentConnect.ViewModels
{
    public class SuperAdminLoginViewModel
    {
        [Required]
        [DisplayName("Super Admin Id")]
        public string SuperAdminId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}