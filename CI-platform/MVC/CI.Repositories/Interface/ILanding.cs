using CI.Entity.Models;
using CI.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Repositories.Interface
{
    public interface ILanding
    {
         List<Mission> GetCard();
    }
}
