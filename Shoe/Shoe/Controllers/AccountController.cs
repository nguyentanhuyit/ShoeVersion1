using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoe.Models.DBModels;
using Shoe.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.Controllers
{
    public class AccountController : Controller
    {
        private IUserService userService;
        private IUserRoleService userRoleService;
        public AccountController(IUserService user, IUserRoleService userRole)
        {
            userService = user;
            userRoleService = userRole;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoLogin([FromForm] User userLogin)
        {
            User user = userService.login(userLogin);
            if (user == null)
            {
                ViewBag.Error = "Thông tin đăng nhập không hợp lệ";
                return View("Login");
            }
            else if (user != null)
            {
                ViewBag.Error = "";
                HttpContext.Session.SetString("id", user.Id.ToString());
                HttpContext.Session.SetString("userName", user.Username);
                HttpContext.Session.SetString("password", user.Password);
                HttpContext.Session.SetString("email", user.Email);

                TempData["UserName"] = HttpContext.Session.GetString("userName");
                TempData.Keep();

                return Redirect("/home");
            }
            return View("Login");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult DoSignUp([FromForm] User user)
        {
            UserRole userRole = new UserRole();
            user.Username = "account";
            User u = userService.signUp(user);
            userRole.UserId = u.Id;
            userRole.RoleId = 1;
            userRoleService.addUserRole(userRole);
            return Redirect("/Account/Login");
        }
        public IActionResult Logout()
        {
            
            return Redirect("Account/Login");
        }
    }
}
