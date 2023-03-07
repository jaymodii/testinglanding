using CI.Entity.Data;
using CI.Entity.Models;
using CI.Entity.ViewModels;
using CI.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CIPlatform.Controllers.Users
{
    public class UserController : Controller
    {
        public readonly IUser _IUser;
        public readonly DatabasewithDataContext _db;
        public UserController(IUser UserRepository, DatabasewithDataContext db)
        {
            _IUser = UserRepository;
            _db = db;
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Registration obj)
        {
            User user = new User();
            {
                user.Email = obj.Email;
                user.Password = obj.Password;
                user.FirstName = obj.FirstName;
                user.LastName = obj.LastName;
                user.PhoneNumber = obj.PhoneNumber.ToString();
            }

            var check = _IUser.Register(user);

            if (check != null)
            {
                TempData["Message"] = "User Already Exists";
                return RedirectToAction("Register");

            }
            TempData["Message"] = "You are Successfully Registered";
            return RedirectToAction("Index","User");



        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User obj)
        {
            var user = _IUser.Index(obj);
            if (user == null)
            {
                TempData["Message"] = "Invalid User or Password";
                return View();
            }

            //Session Management

            HttpContext.Session.SetString("username", user.FirstName +" "+ user.LastName);
            //_IUser.login(objlogin);
            return RedirectToAction("LandingPage", "Landing");



            //if (_CiPlatformDb.Users.Any(u => u.Email == objlogin.Email && u.Password == objlogin.Password))
            //{ return RedirectToAction("landingpage", "Home"); }
            //return RedirectToAction("landingpage", "Home");

        }



        //----------------------------------------------------------------------------------------


        public IActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ForgotPassword(User obj)
        {
            var user = _IUser.ForgotPassword(obj);

            if (user == null)
            {
                TempData["Message"] = "Invalid Email";
                return View();
            }
            TempData["Message"] = "Check your email to reset password";
            return RedirectToAction("Index","User");


        }


        public IActionResult ResetPassword()
        {


            return View();
        }



        [HttpPost]
        public IActionResult ResetPassword(User obj, String token)
        {

            var validToken = _IUser.ResetPassword(obj, token);

            if (validToken != null)
            {
                TempData["Message"] = "Your Password is changed";
                return RedirectToAction("Index");
            }

            TempData["Message"] = "Token not Found";
            return RedirectToAction("Index", "User");

        }

    }
}

