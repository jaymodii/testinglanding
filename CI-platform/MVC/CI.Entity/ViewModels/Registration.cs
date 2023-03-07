using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Entity.ViewModels
{
    public class Registration

    {
        [Required(ErrorMessage = "Please Enter valid first name. ")]

        public string? FirstName { get; set; } = null!;

        public string? LastName { get; set; } = null;

        [Required(ErrorMessage = "Please Enter registered Email ")]
        //[RegularExpression(".+\\@.+\\.+",ErrorMessage ="Enter valid mail address")]
        public string Email { get; set; } = null!;

        [Required]

        //[StringLength(100,MinimumLength =8,ErrorMessage = "Please Enter minimum 8 character password.")]

        public string Password { get; set; } = null!;

        [Required]

        [Compare("Password",ErrorMessage ="Please enter confirm password same as Password.")]
        public string ConfirmPassword { get; set; } = null!;

        [Required]

        public int PhoneNumber { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
   
}
