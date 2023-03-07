using CI.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Entity.ViewModels
{
    public class landing

    {
        public List<Country> Countries { get; set; } 

        public List<City> Cities { get; set;}

        public List<MissionTheme> MissionThemes { get; set; }

        public List<Skill> Skills { get; set; }

        public List<GoalMission> GoalMissions { get; set; }

        public List<Mission> Missions { get; set; }

        //public long MissionId { get; set; }

        //public long MissionThemeId { get; set; }

        //public long CityId { get; set; }

        //public long CountryId { get; set; }

        //public string Title { get; set; } = null!;

        //public string? ShortDescription { get; set; }

        //public string? Description { get; set; }

        //public DateTime? StartDate { get; set; }

        //public DateTime? EndDate { get; set; }

        //public string MissionType { get; set; } = null!;

        //public bool? Status { get; set; }

        //public string? OrganizationName { get; set; }

        //public string? OrganizationDetail { get; set; }

    }
}
