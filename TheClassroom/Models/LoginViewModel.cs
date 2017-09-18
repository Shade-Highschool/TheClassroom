using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheClassroom.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musíte zadat svůj email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Toto není email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musíte zadat vaše heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; }

        [Display(Name = "Zapamatovat si mě ?")]
        public bool RememberMe { get; set; }
    }
}