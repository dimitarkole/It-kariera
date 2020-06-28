using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Models.User
{
    public class RegisterUserViewModel
    {
        [Required]
        [Display(Name = "User name")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Passwords not equals")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Full name")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [DataType(DataType.Text)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
