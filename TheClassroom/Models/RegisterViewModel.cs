using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheClassroom.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Musíte zadat svůj email")]
        [EmailAddress(ErrorMessage = "Toto není email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Musíte zadat vaše heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potvrdit heslo")]
        [Compare("Password", ErrorMessage = "Hesla se neshodují")]
        public string ConfirmPassword { get; set; }

    }
}