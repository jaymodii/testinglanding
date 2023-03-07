using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Entity.ViewModels
{
    
        public class LogIn
        {
            [Required(ErrorMessage = "Please Enter registered Email ")]


            public string Email { get; set; } = null!;

            [Required]

            public string Password { get; set; } = null!;
        }
    
}
