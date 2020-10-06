using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeacherStudentConnect.Models;
using TeacherStudentConnect.ViewModels;

namespace TeacherStudentConnect.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbConnect context = new ApplicationDbConnect();

        public ActionResult Index()
        {
            return View();
        }
        //GET:/Admin/Login
        [AllowAnonymous]
        public ActionResult AdminLogin()
        {
            return View();
        }

        //POST:/Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(AdminLoginViewModel admin)
        {
            var searchUser = context.Admins.Where(x => x.AdminId == admin.AdminId &&
              x.Password == admin.Password).FirstOrDefault();
            TempData["UserID"] = admin.AdminId;
            if (searchUser != null) //if username and password is matching
            {
                if(searchUser.AdminProfileStatus==Admin.Approved)
                {
                    //return RedirectToAction("UserDetails");
                }
                else
                {
                    ViewBag.LoginError = "Admin Profile status is " + searchUser.AdminProfileStatus;
                }
                
            }
            else //if username and password is not matching
            {
                ViewBag.LoginError = "Login Failed. Incorrect Admin Id or Password";
            }
            return View();
        }


        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult AdminRegister()
        {
            var adminModel = new Admin();
            //ViewBag.CategoryList = userModel.CategoryList.ToList();
            //ViewBag.SubjectList = userModel.SubjectList.ToList();
            return View(adminModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminRegister(Admin admin)
        {
                if (ModelState.IsValid)
                {
                    admin.AdminProfileStatus = Admin.Pending;
                    context.Admins.Add(admin);
                    context.SaveChanges();
                    ViewBag.Success = "Admin Registered Successfully";
                    return View();
                }
                else
                {
                    ViewBag.Failure = "Admin Registration Failed";
                    return View();
                }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}