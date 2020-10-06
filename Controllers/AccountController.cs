using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TeacherStudentConnect.Models;
using TeacherStudentConnect.ViewModels;

namespace TeacherStudentConnect.Controllers
{
    
    public class AccountController : Controller
    {
        private ApplicationDbConnect context = new ApplicationDbConnect();
        //GET:/Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        //POST:/Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel login)
        {
            var searchUser = context.Users.Where(x => x.UserId == login.UserId &&
              x.Password == login.Password).FirstOrDefault();
            TempData["UserID"] = login.UserId;
            TempData.Keep();
            if (searchUser != null) //if username and password is matching
            {
                if(searchUser.Category=="Teacher")
                {
                    return RedirectToAction("MyProfile", "Account");
                }
                else
                {
                    return RedirectToAction("MyProfile");
                } 
            }
            else //if username and password is not matching
            {
                ViewBag.LoginError = "Login Failed. Incorrect User Id or Password";
            }
            return View();
        }
        

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            var userModel = new User();
            //var userModel = new UserViewModel();
            //var data = (from x in userModel.SubjectList select x.Value).Distinct();
            //var categorydata = (from x in userModel.CategoryList select x.Value).Distinct();
            //ViewBag.CategoryList = categorydata;
            //ViewBag.SubjectList = data;
            return View(userModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {

            //var userModel = new UserViewModel();
            //var data = (from x in userModel.SubjectList select x.Value).Distinct();
            //var categorydata = (from x in userModel.CategoryList select x.Value).Distinct();
            //ViewBag.CategoryList = categorydata;
            //ViewBag.SubjectList = data;
            if (ModelState.IsValid)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    ViewBag.Success = "User Registered Successfully";
                    return View();
                }
                else
                {
                    ViewBag.Failure = "User Registration Failed";
                    return View();
                }
                
        }
        
        public ActionResult MyProfile()
        {
            var UserId =(string) TempData["UserId"];
            var user = context.Users.Where(x => x.UserId == UserId).FirstOrDefault();
            return View(user);
        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        context.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}