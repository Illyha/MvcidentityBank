using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcidentityBank.Models.ViewModels
{
    public class RegisterModel1
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords are not the same!!!")]
        public string PasswordConfirm { get; set; }

        [Required]
        public string SkinColor { get; set; }

    }
}