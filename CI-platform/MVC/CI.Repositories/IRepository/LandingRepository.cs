using CI.Entity.Data;
using CI.Entity.Models;
using CI.Entity.ViewModels;
using CI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Repositories.IRepository
{
    public class LandingRepository : ILanding
    {
        public readonly DatabasewithDataContext _db;

        public LandingRepository(DatabasewithDataContext db)
        {
            _db = db;
        }



        public List<Mission> GetCard()
        {
           
            List<Mission> MissionList = _db.Missions.Include(x => x.Country).Include(x => x.City).Include(x => x.MissionTheme).Include(x => x.MissionSkills).ToList();

            return MissionList;
        
        }


        
       

        //List<landing> cardmodel=new List<landing>();
        //var countries=_db.Countries.ToList();
        //var cities=_db.Cities.ToList();
        //var themes = _db.MissionThemes.ToList();
        //var skills= _db.Skills.ToList();
        //var goalmissions=_db.GoalMissions.ToList();
        //var missions=_db.Missions.ToList();
        //foreach(var m in missions)
        //{
        //    var city=_db.Cities.FirstOrDefault(x=>x.CityId==m.CityId);
        //    var theme=_db.MissionThemes.FirstOrDefault(x=>x.MissionThemeId==m.MissionThemeId);      
        //    var skill=_db.Skills.FirstOrDefault(x=>x.SkillId==m.);

        //}

    }
}
