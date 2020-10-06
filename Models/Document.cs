using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeacherStudentConnect.Models;

namespace TeacherStudentConnect.Models
{
    public class Document
    {
        [Required]
        public string DocumentId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public int CompetencyLevel { get; set; }

        [Required]
        public string IntendedAudience { get; set; }

        //public 

    }
}