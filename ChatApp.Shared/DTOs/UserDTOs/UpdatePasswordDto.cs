using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.UI.Shared.DTOs.UserDTOs
{
    public class UpdatePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordAgain { get; set; }
    }
}
