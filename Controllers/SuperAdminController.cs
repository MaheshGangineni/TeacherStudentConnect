using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TeacherStudentConnect.Models;
using TeacherStudentConnect.ViewModels;

namespace TeacherStudentConnect.Controllers
{
    public class SuperAdminController : Controller
    {
        private ApplicationDbConnect context = new ApplicationDbConnect();
        public ActionResult Index()
        {
            return View();
        }
        // GET: SuperAdmin
        [AllowAnonymous]
        public ActionResult SuperLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SuperLogin(SuperAdminLoginViewModel superAdmin)
        {
            var sadmin = context.SuperAdmins.Where(x => x.SuperAdminId == superAdmin.SuperAdminId &&
              x.Password == superAdmin.Password).FirstOrDefault();
            TempData["UserID"] = superAdmin.SuperAdminId;
            if (sadmin != null) //if username and password is matching
            {
                return RedirectToAction("Index","SuperAdmin");
            }
            else //if username and password is not matching
            {
                ViewBag.LoginError = "Login Failed. Incorrect Super Admin Id or Password";
            }
            return View();
        }
        public ActionResult AdminRequest()
        {
            var adminList = context.Admins.ToList();
            return View(adminList);
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = context.Admins.Where(x => x.AdminId == id).FirstOrDefault();
            if (admin == null)
            {
                return HttpNotFound();
            }
            TempData["AdminId"] = admin.AdminId;
            return View(admin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Admin admin)
        {
            /*admin.AdminId = (string)TempData["AdminId"];
            var searchAdmin = context.Admins.Where(x => x.AdminId == admin.AdminId).FirstOrDefault();
            admin.Password = searchAdmin.Password;*/
            if (ModelState.IsValid)
            {
                var searchAdmin = context.Admins.Where(x => x.AdminId == admin.AdminId).FirstOrDefault();
                searchAdmin.AdminProfileStatus = admin.AdminProfileStatus;
                context.SaveChanges();
                return RedirectToAction("AdminRequest");
            }
            else
            {
                ViewBag.StatusError = "Unable to update status";
            }
            return View(admin);
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