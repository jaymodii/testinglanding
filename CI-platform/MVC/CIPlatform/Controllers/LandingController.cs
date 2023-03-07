using Microsoft.AspNetCore.Mvc;
using CI.Entity.Models;
using CI.Entity.Data;
using CI.Repositories.Interface;
using CI.Entity.ViewModels;

namespace CIPlatform.Controllers
{
    public class LandingController : Controller
    {
        public readonly ILanding _ILanding;
             public readonly DatabasewithDataContext _db;
        public LandingController( DatabasewithDataContext db,ILanding landing)
        {
           _ILanding = landing;
            _db = db;
        }

        public IActionResult LandingPage()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                ViewBag.username = HttpContext.Session.GetString("username");
            }



            landing vm = new landing();
            vm.Missions = _ILanding.GetCard();
            //{

            //vm.Countries = _db.Country.ToList();
            //vm.Cities = _db.Cities.ToList();
            //vm.MissionThemes = _db.MissionThemes.ToList();
            //vm.Skills = _db.Skills.ToList();
            return View(vm);
        }


            
        }
    }
}
