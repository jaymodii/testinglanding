
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CI.Entity.ViewModels;


//using CI.Entity.Models;
using CIPlatform.Models;

namespace CIPlatform.Controllers
{
    //public class HomeController : Controller
    //{
    //    ////private readonly CiplatformContext _db;

    //    //public HomeController(CiplatformContext db)
    //    //{
    //    //    _db = db;
    //    //}

    //    ////private readonly ILogger<HomeController> _logger;

    //    ////public HomeController(ILogger<HomeController> logger)
    //    ////{
    //    ////    _logger = logger;
    //    ////}

    //    [HttpGet]
    //    public IActionResult Index()
    //    {            
    //        return View();
    //    }


    //    [HttpPost]
    //    public IActionResult Index(LogIn auth)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var status = _db.Users.Where(l => l.Email == auth.Email && l.Password == auth.Password).FirstOrDefault();
    //            if (status != null)
    //            {
    //                return RedirectToAction("LandingPage", "Landing");
    //            }
    //            else
    //            {
    //                return View();
    //            }
    //        }
    //        return View();
    //    }




    //    [HttpGet]
    //    //GET
    //    public IActionResult Register()
    //    {
    //        return View();
    //    }
    //    //POST
    //    [HttpPost]

    //    //public IActionResult Register(Registration RegisterData)
    //    //{
    //    //    // Registration.CreatedAt(DateTime.Now());
    //    //    User user = new User()
    //    //    {
    //    //        FirstName = RegisterData.FirstName,
    //    //        LastName = RegisterData.LastName,
    //    //        Email = RegisterData.Email,
    //    //        Password = RegisterData.Password,
    //    //        PhoneNumber = RegisterData.PhoneNumber,
                
               
    //    //    };
            
    //    //    if (ModelState.IsValid)
    //    //    {   
    //    //        _db.Users.Add(user);
    //    //        _db.SaveChanges();
               
    //    //        TempData["AlertMessage"] = "Your account is registered successfully.Log in now!!";
    //    //        return RedirectToAction("Index", "Home");
    //    //    }


    //    //        return View();
    //    //}


    //    //public IActionResult ForgotPassword()
    //    //{
    //    //    return View();
    //    //}


    //    [HttpPost]
    //    public IActionResult ForgotPassword(ForgotMail mail)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var status = _db.Users.Where(m=>m.Email==mail.Email).FirstOrDefault();
    //            if (status != null)
    //            {
    //                return RedirectToAction("ResetPassword", "Home");
    //            }
    //            else
    //            {
    //                return View();
    //            }
    //        }
    //        return View();
           
    //    }


    //    public IActionResult ResetPassword()
    //    {
    //        return View();
    //    }
        
    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }

    //    [HttpPost]
    //    //public IActionResult ForgotPassword(ForgotMail viewmodel)
    //    //{


    //    //    if (ModelState.IsValid)
    //    //    {
    //    //        CiplatformDbContext context = new CiplatformDbContext();

    //    //        var data = context.Users.Where(e => e.Email == viewmodel.Email).FirstOrDefault();

    //    //        if (data != null)
    //    //        {

    //    //            Random random = new Random();

    //    //            int capitalCharCode = random.Next(65, 91);
    //    //            char randomCapitalChar = (char)capitalCharCode;


    //    //            int randomint = random.Next();


    //    //            int SmallcharCode = random.Next(97, 123);
    //    //            char randomChar = (char)SmallcharCode;

    //    //            String token = "";
    //    //            token += randomCapitalChar.ToString();
    //    //            token += randomint.ToString();
    //    //            token += randomChar.ToString();


    //    //            var PasswordResetLink = Url.Action("ResetPassword", "Home", new { Email = viewmodel.Email, Token = token }, Request.Scheme);

    //    //            var ResetPasswordInfo = new PasswordReset()
    //    //            {
    //    //                Email = viewmodel.Email,
    //    //                Token = token
    //    //            };
    //    //            context.PasswordResets.Add(ResetPasswordInfo);
    //    //            context.SaveChanges();


    //    //            var fromEmail = new mailaddress("akshayghadiya7@gmail.com");
    //    //            var toEmail = new MailAddress(viewmodel.Email);
    //    //            var fromEmailPassword = "zapyrgadwtwqjnid";
    //    //            string subject = "Reset Password";
    //    //            string body = PasswordResetLink;

    //    //            var smtp = new SmtpClient
    //    //            {

    //    //                Host = "smtp.gmail.com",
    //    //                Port = 587,
    //    //                EnableSsl = true,
    //    //                DeliveryMethod = SmtpDeliveryMethod.Network,
    //    //                UseDefaultCredentials = false,
    //    //                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
    //    //            };

    //    //            MailMessage message = new MailMessage(fromEmail, toEmail);
    //    //            message.Subject = subject;
    //    //            message.Body = body;
    //    //            message.IsBodyHtml = true;
    //    //            smtp.Send(message);


    //    //        }
    //    //        else
    //    //        {
    //    //            ModelState.AddModelError("Email", "Email is not Registered");

    //    //        }
    //    //    }
    //    //    else
    //    //    {
    //    //        return View(viewmodel);
    //    //    }
    //    //    return View(viewmodel);
    //    //}
    //    public IActionResult ResetPassword(String email, String token)
    //    {

    //        FormValidationForResetPasswordPage validation = new FormValidationForResetPasswordPage()
    //        {
    //            Email = email,
    //            Token = token
    //        };


    //        return View(validation);

    //    }

    //    [HttpPost]
    //    //public IActionResult ResetPAssword(FormValidationForResetPasswordPage viewmodel)
    //    //{
    //    //    CiplatformDbContext context = new CiplatformDbContext();

    //    //    var ResetPasswordData = context.PasswordResets.Any(e => e.Email == viewmodel.Email && e.Token == viewmodel.Token);


    //    //    if (ResetPasswordData)
    //    //    {
    //    //        var x = context.Users.FirstOrDefault(e => e.Email == viewmodel.Email);


    //    //        x.Password = viewmodel.Password;


    //    //        context.Users.Update(x);
    //    //        context.SaveChanges();

    //    //    }
    //    //    else
    //    //    {
    //    //        ModelState.AddModelError("Token", "Reset Passwordword Link is Invalid");
    //    //    }
    //    //    return View(viewmodel);
    //    //}
    //}
}