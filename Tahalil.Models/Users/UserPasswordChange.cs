using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahalil.Models.Users
{
    public class UserPasswordChange
    {
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "Error Password!")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
