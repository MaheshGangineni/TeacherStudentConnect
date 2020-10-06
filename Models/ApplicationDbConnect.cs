using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TeacherStudentConnect.Models
{
    public class ApplicationDbConnect:DbContext
    {
        public ApplicationDbConnect():base("TeacherStudentConnect")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<SuperAdmin> SuperAdmins { get; set; }
    }
}