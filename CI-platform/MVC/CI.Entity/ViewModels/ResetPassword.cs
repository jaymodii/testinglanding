using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Entity.ViewModels
{
    public class ResetPassword
    {
        [Required]

        //[StringLength(100,MinimumLength =8,ErrorMessage = "Please Enter minimum 8 character password.")]

        public string Password { get; set; } = null!;

        [Required]

        [Compare("Password", ErrorMessage = "Please enter confirm password same as Password.")]
        public string ConfirmPassword { get; set; } = null!;

    }
}
